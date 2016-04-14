using System;
using System.Collections.Generic;
using System.Text;
using Marker = GMap.NET.WindowsForms.Markers.GMarkerGoogle;

namespace CoreMaps
{
    class ActivityLocation
    {
        public ActivityLocation() { }

        public string SearchString { get; set; }
        public Marker Marker { get; set; }
        public bool ChildrensClass { get; set; }
        public bool JuniorYouthGroup { get; set; }
        public bool DevotionalMeeting { get; set; }
        public bool StudyCircle { get; set; }
    }
}
