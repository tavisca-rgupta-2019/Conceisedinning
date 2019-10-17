
using ConceiseDinning.Adapter.Geocoder.xyz.Models;
using System.Collections.Generic;
using System.IO;

namespace ConceiseDinning.Core.Translator
{
    public class RestrauntFinderForTableBooking
    {
        public List<double> GetRestarauntDetails(string LocalityVerbose)
        {
            //RetrauntSearchForTableBooking restrauntFinderForTableBooking = new RetrauntSearchForTableBooking();
            return RestarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(LocalityVerbose);
        }
        
        
    }
}
