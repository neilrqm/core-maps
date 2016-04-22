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

        private enum MarkerState
        {
            Selected,
            NotSelected,
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
            SetUiState(ButtonState.Search); // first set action button to search, because we want it in that mode
            SetUiState(ButtonState.Off);    // then set action button to off, to disable it since the text box starts blank
            locations = new List<ActivityLocation>();

            // test code
            searchTextBox.Text = "631 Jolly Pl.";
        }

        private void SetUiState(ButtonState state)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<ButtonState>(SetUiState), state);
                return;
            }
            buttonState = state;
            switch (state)
            {
                case ButtonState.Search:
                    actionButton.Text = "Search";
                    ccCheckBox.Enabled = true;
                    jyCheckBox.Enabled = true;
                    dmCheckBox.Enabled = true;
                    scCheckBox.Enabled = true;
                    actionButton.Enabled = true;
                    break;
                case ButtonState.Delete:
                    actionButton.Text = "Delete";
                    ccCheckBox.Enabled = true;
                    jyCheckBox.Enabled = true;
                    dmCheckBox.Enabled = true;
                    scCheckBox.Enabled = true;
                    actionButton.Enabled = true;
                    break;
                case ButtonState.Off:
                    actionButton.Enabled = false;
                    ccCheckBox.Enabled = false;
                    jyCheckBox.Enabled = false;
                    dmCheckBox.Enabled = false;
                    scCheckBox.Enabled = false;
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

        private Bitmap MakeMarkerImage(ActivityLocation location, MarkerState markerState)
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
            if (markerState == MarkerState.NotSelected)
            {
                const int change = -30;     // change this value to make not-selected image darker/lighter
                Bitmap darkerImage = new Bitmap(markerImage);
                for (int i = 0; i < darkerImage.Width; i++)
                {
                    for (int j = 0; j < darkerImage.Height; j++)
                    {
                        Color oldColor = darkerImage.GetPixel(i, j);
                        int a = oldColor.A;
                        int r = oldColor.R + change < 0 ? 0 : oldColor.R + change > 255 ? 255 : oldColor.R + change;
                        int g = oldColor.G + change < 0 ? 0 : oldColor.G + change > 255 ? 255 : oldColor.G + change;
                        int b = oldColor.B + change < 0 ? 0 : oldColor.B + change > 255 ? 255 : oldColor.B + change;
                        Color newColor = Color.FromArgb(a, r, g, b);
                        darkerImage.SetPixel(i, j, newColor);
                    }
                }
                return darkerImage;
            }
            return markerImage;
        }

        private void SelectLocation(ActivityLocation location)
        {
            // unselect currently selected location
            if (selectedLocation != null)
            {
                overlay.Markers.Remove(selectedLocation.Marker);
                selectedLocation.Marker = new Marker(selectedLocation.Marker.Position, MakeMarkerImage(selectedLocation, MarkerState.NotSelected));
                overlay.Markers.Add(selectedLocation.Marker);
                selectedLocation = null;
            }
            // select new location
            if (location != null)
            {
                selectedLocation = location;
                searchTextBox.Text = selectedLocation.SearchString;
                ccCheckBox.Checked = selectedLocation.ChildrensClass;
                jyCheckBox.Checked = selectedLocation.JuniorYouthGroup;
                dmCheckBox.Checked = selectedLocation.DevotionalMeeting;
                scCheckBox.Checked = selectedLocation.StudyCircle;
                if (selectedLocation.Marker != null)
                {
                    overlay.Markers.Remove(selectedLocation.Marker);
                }
                Marker newMarker = new Marker(mapControl.Position, MakeMarkerImage(selectedLocation, MarkerState.Selected));
                selectedLocation.Marker = newMarker;
                overlay.Markers.Add(newMarker);
                if (!locations.Contains(selectedLocation))
                {
                    locations.Add(selectedLocation);
                }
            }
        }

        private void CoreMaps_Load(object sender, EventArgs e)
        {
            InitializeMapControl();
        }

        private void mapControl_Click(object sender, EventArgs e)
        {
            SelectLocation(null);
            if (buttonState == ButtonState.Delete)
            {
                SetUiState(ButtonState.Search);
                searchTextBox.Text = "";
                ccCheckBox.Checked = false;
                jyCheckBox.Checked = false;
                dmCheckBox.Checked = false;
                scCheckBox.Checked = false;
            }
        }

        private void mapControl_MarkerClicked(GMap.NET.WindowsForms.GMapMarker marker, MouseEventArgs args)
        {
            ActivityLocation location = null;
            foreach (ActivityLocation l in locations)
            {
                GMap.NET.SizeLatLng distance = (l.Marker.Position - marker.Position);
                if (Math.Sqrt(distance.HeightLat * distance.HeightLat + distance.WidthLng * distance.WidthLng) < 0.0001)
                {
                    location = l;
                    break;
                }
            }
            if (location == null)
            {
                throw new Exception("User clicked a marker with no location associated with it.");
            }
            SelectLocation(location);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                SetUiState(ButtonState.Off);
            }
            else if (selectedLocation != null && selectedLocation.SearchString == searchTextBox.Text)
            {
                SetUiState(ButtonState.Delete);
            }
            else
            {
                SetUiState(ButtonState.Search);
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
                        locations.Remove(selectedLocation);
                        selectedLocation = null;
                        SetUiState(ButtonState.Search);
                    }
                    else
                    {
                        throw new Exception("User was able to delete a marker with none selected.");
                    }
                    break;
                case ButtonState.Search:
                    mapControl.SetPositionByKeywords(searchTextBox.Text);
                    SetUiState(ButtonState.Delete);
                    foreach (ActivityLocation l in locations)
                    {
                        if (l.Marker.Position == mapControl.Position)
                        {
                            SelectLocation(l);
                            return;
                        }
                    }
                    
                    SetUiState(ButtonState.Delete);
                    ActivityLocation location = new ActivityLocation();
                    location.SearchString = searchTextBox.Text;
                    location.ChildrensClass = ccCheckBox.Checked;
                    location.JuniorYouthGroup = jyCheckBox.Checked;
                    location.DevotionalMeeting = dmCheckBox.Checked;
                    location.StudyCircle = scCheckBox.Checked;
                    SelectLocation(location);
                    break;
                case ButtonState.Off:
                    throw new Exception("User was able to click action button in off state.");
            }
        }

        private void CoreMaps_FormClosing(object sender, FormClosingEventArgs e)
        {
            mapControl.Dispose();
        }

        private void clearMarkersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ActivityLocation l in locations)
            {
                l.Marker.Dispose();
                overlay.Markers.Remove(l.Marker);
            }
            locations = new List<ActivityLocation>();
            selectedLocation = null;
        }

        private void saveMarkersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadMarkersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
