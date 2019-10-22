using ConceiseDinning.Core.Models;
using ConceiseDinning.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using ConceiseDinning.Adapter.Geocoder.xyz.Models;
using System.Net;
using System.Text;

namespace ConceiseDinning.Adapter.Geocoder.xyz.Models
{
    public class RestarauntGeocodeLocator
    {
        public GeocodeLocator GetRestarauntGeocodeCoordinates(string locality)
        {
            WebClient client = new WebClient();
            GeocodeLocator restarauntGeocode = new GeocodeLocator();
            restarauntGeocode.Longitude = 0.00; restarauntGeocode.Latitude = 0.00; restarauntGeocode.CountryName = string.Empty;
            string url = "https://geocode.xyz/?locate=" + locality + "&json=1";
            var reply = client.DownloadString(url);
            if (!reply.Contains("\"0.00000\""))
            {
                var jobject = JsonConvert.DeserializeObject<RestarauntCoordinates>(reply);
                restarauntGeocode.Latitude = Convert.ToDouble(jobject.latt);
                restarauntGeocode.Longitude = Convert.ToDouble(jobject.longt);
                restarauntGeocode.CountryName = jobject.standard.countryname;
                return restarauntGeocode;
            }
            return restarauntGeocode;
        }
    }
}
