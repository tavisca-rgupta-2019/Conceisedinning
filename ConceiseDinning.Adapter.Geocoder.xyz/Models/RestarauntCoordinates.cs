using System;
using System.Collections.Generic;
using System.Text;

namespace ConceiseDinning.Adapter.Geocoder.xyz.Models
{
    public class RestarauntCoordinates
    { 
    }
        public class Postal
        {
        }

        public class Standard
        {
            public string stnumber { get; set; }
            public string addresst { get; set; }
            public Postal postal { get; set; }
            public string region { get; set; }
            public string prov { get; set; }
            public string city { get; set; }
            public string countryname { get; set; }
            public string confidence { get; set; }
        }

        public class Alt
        {
        }

        public class Elevation
        {
        }

        public class RootObject
        {
            public Standard standard { get; set; }
            public string longt { get; set; }
            public Alt alt { get; set; }
            public Elevation elevation { get; set; }
            public string latt { get; set; }
        }
    

}
