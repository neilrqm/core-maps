using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoreMaps
{
    public partial class CoreMaps : Form
    {
        public CoreMaps()
        {
            InitializeComponent();
        }

        private void CoreMaps_Load(object sender, EventArgs e)
        {
            // Initialize map control
            mapControl.MapProvider = GMap.NET.MapProviders.OpenStreetMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            mapControl.Position = new GMap.NET.PointLatLng(48.455, -123.38);    // Centre map of Victoria in the window
        }
    }
}
