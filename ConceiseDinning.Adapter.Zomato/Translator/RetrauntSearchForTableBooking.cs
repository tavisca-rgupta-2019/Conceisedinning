using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;



namespace ConceiseDinning.Adapter.Zomato.Translator
{
    public class RetrauntSearchForTableBooking
    {
        public Models.Restaurant FetchRestrauntDetails(Double[] coordinates)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://developers.zomato.com/api/v2.1/search?{coordinates[0]}&{Coordinates[1]}&count=20&apikey=cd6e9a5ee0b54d7998c8ffff68b2751e");
            var jsonObject = JsonConvert.DeserializeObject<Models.Restaurant>(reply);
            return jsonObject;
        }
    }
}
