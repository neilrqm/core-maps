using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Marker = GMap.NET.WindowsForms.Markers.GMarkerGoogle;

namespace CoreMaps
{
    public partial class CoreMaps : Form
    {
        private enum ButtonState
        {
            Search,
            Delete,
            Off,
        }

        // default provider is OpenStreetMap
        private GMap.NET.MapProviders.GMapProvider provider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
        private GMap.NET.WindowsForms.GMapOverlay overlay;
        private ButtonState buttonState;
        private List<ActivityLocation> locations;
        private ActivityLocation selectedLocation;

        public CoreMaps()
        {
            InitializeComponent();
            SetButtonState(ButtonState.Search); // first set action button to search, because we want it in that mode
            SetButtonState(ButtonState.Off);    // then set action button to off, to disable it since the text box starts blank
            locations = new List<ActivityLocation>();

            // test code
            searchTextBox.Text = "631 Jolly Pl.";
        }

        private void SetButtonState(ButtonState state)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ButtonState>(SetButtonState), state);
                return;
            }
            buttonState = state;
            switch (state)
            {
                case ButtonState.Search:
                    actionButton.Text = "Search";
                    actionButton.Enabled = true;
                    break;
                case ButtonState.Delete:
                    actionButton.Text = "Delete";
                    actionButton.Enabled = true;
                    break;
                case ButtonState.Off:
                    actionButton.Enabled = false;
                    break;
            }
        }

        private void InitializeMapControl()
        {
            mapControl.MapProvider = provider;  // Use selected provider instance
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;  // allow downloading and caching map tiles
            mapControl.Position = new GMap.NET.PointLatLng(48.455, -123.38);    // Centre map of Victoria in the window
            mapControl.ShowCenter = false;  // don't show crosshair
            mapControl.OnMarkerClick += mapControl_MarkerClicked;
            overlay = new GMap.NET.WindowsForms.GMapOverlay();
            mapControl.Overlays.Add(overlay);
        }

        private Bitmap ChangeIntensity(Bitmap original, int change)
        {
            Bitmap newImage = new Bitmap(original);
            for (int i = 0; i < newImage.Width; i++)
            {
                for (int j = 0; j < newImage.Height; j++)
                {
                    Color oldColor = newImage.GetPixel(i, j);
                    int a = oldColor.A;
                    int r = oldColor.R + change < 0 ? 0 : oldColor.R + change > 255 ? 255 : oldColor.R + change;
                    int g = oldColor.G + change < 0 ? 0 : oldColor.G + change > 255 ? 255 : oldColor.G + change;
                    int b = oldColor.B + change < 0 ? 0 : oldColor.B + change > 255 ? 255 : oldColor.B + change;
                    Color newColor = Color.FromArgb(a, r, g, b);
                    newImage.SetPixel(i, j, newColor);
                }
            }
            return newImage;
        }

        private Bitmap MakeMarkerImage(ActivityLocation location)
        {
            Bitmap markerImage = new Bitmap(Properties.Resources.icon_dot);
            using (Graphics g = Graphics.FromImage(markerImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                if (location.ChildrensClass)
                    g.DrawImage(Properties.Resources.icon_cc, new Rectangle(new Point(), Properties.Resources.icon_cc.Size), new Rectangle(new Point(), Properties.Resources.icon_cc.Size), GraphicsUnit.Pixel);
                if (location.JuniorYouthGroup)
                    g.DrawImage(Properties.Resources.icon_jy, new Rectangle(new Point(), Properties.Resources.icon_cc.Size), new Rectangle(new Point(), Properties.Resources.icon_cc.Size), GraphicsUnit.Pixel);
                if (location.DevotionalMeeting)
                    g.DrawImage(Properties.Resources.icon_dm, new Rectangle(new Point(), Properties.Resources.icon_cc.Size), new Rectangle(new Point(), Properties.Resources.icon_cc.Size), GraphicsUnit.Pixel);
                if (location.StudyCircle)
                    g.DrawImage(Properties.Resources.icon_sc, new Rectangle(new Point(), Properties.Resources.icon_cc.Size), new Rectangle(new Point(), Properties.Resources.icon_cc.Size), GraphicsUnit.Pixel);
                g.Save();
            }
            return markerImage;
        }

        private void CoreMaps_Load(object sender, EventArgs e)
        {
            InitializeMapControl();
        }

        private void mapControl_MarkerClicked(GMap.NET.WindowsForms.GMapMarker marker, MouseEventArgs args)
        {
            ActivityLocation location = null;
            foreach (ActivityLocation l in locations)
            {
                if (l.Marker == marker)
                {
                    location = l;
                    break;
                }
            }
            if (location == null)
            {
                throw new Exception("User clicked a marker with no location associated with it.");
            }
            overlay.Markers.Remove(location.Marker);
            location.Marker = new Marker(location.Marker.Position, MakeMarkerImage(location));
            overlay.Markers.Add(location.Marker);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                SetButtonState(ButtonState.Off);
            }
            else if (selectedLocation != null)
            {
                SetButtonState(ButtonState.Delete);
            }
            else
            {
                SetButtonState(ButtonState.Search);
            }
        }

        private void actionButton_Click(object sender, EventArgs e)
        {
            switch (buttonState)
            {
                case ButtonState.Delete:
                    if (selectedLocation != null)
                    {
                        selectedLocation.Marker.Dispose();
                        overlay.Markers.Remove(selectedLocation.Marker);
                        SetButtonState(ButtonState.Search);
                    }
                    else
                    {
                        throw new Exception("User was able to delete a marker with none selected.");
                    }
                    break;
                case ButtonState.Search:
                    //dot.MakeTransparent(Color.White);
                    Bitmap markerImage = ChangeIntensity(MakeMarkerImage(new ActivityLocation()), -30);
                    mapControl.SetPositionByKeywords(searchTextBox.Text);
                    Marker newMarker = new Marker(mapControl.Position, markerImage);
                    overlay.Markers.Add(newMarker);
                    SetButtonState(ButtonState.Delete);
                    selectedLocation = new ActivityLocation();
                    selectedLocation.SearchString = searchTextBox.Text;
                    selectedLocation.Marker = newMarker;
                    locations.Add(selectedLocation);
                    break;
                case ButtonState.Off:
                    throw new Exception("User was able to click action button in off state.");
            }
        }
    }
}
