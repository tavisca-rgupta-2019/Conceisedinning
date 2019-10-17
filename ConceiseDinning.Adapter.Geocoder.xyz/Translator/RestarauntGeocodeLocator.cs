using ConceiseDinning.Core.Models;
using ConceiseDinning.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace ConceiseDinning.Adapter.Geocoder.xyz.Models
{
    public static class RestarauntGeocodeLocator
    {
        public static List<double>  GetRestarauntGeocodeCoordinates(string localityVerbose)
        {
            
            
            WebClient client = new WebClient();
            List<double> LatLong = new List<double>() { };
            string url = "https://geocode.xyz/?locate=" + localityVerbose + "&json=1";
            var reply = client.DownloadString(url);
            if (!reply.Contains("\"0.00000\""))
            {
                LatLong.Add(Convert.ToDouble(reply.Split("\"longt\" : \"")[1].Split("\"")[0]));
                LatLong.Add(Convert.ToDouble(reply.Split("\"latt\" : \"")[1].Split("\"")[0]));
                return LatLong;
            }
            return LatLong;
        }
    }
}
