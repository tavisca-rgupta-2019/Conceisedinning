
using ConceiseDinning.Adapter.Geocoder.xyz.Models;
using System.Collections.Generic;
using System.IO;
using ConceiseDinning.Core.Models;

namespace ConceiseDinning.Core.Translator
{
    public class RestrauntFinderForTableBooking
    {
        public GeocodeLocator GetRestarauntDetails(string LocalityVerbose)
        {
            //RetrauntSearchForTableBooking restrauntFinderForTableBooking = new RetrauntSearchForTableBooking();
            RestarauntGeocodeLocator restarauntGeocodeLocator = new RestarauntGeocodeLocator();
            return restarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(LocalityVerbose);
        }
        
        
    }
}
