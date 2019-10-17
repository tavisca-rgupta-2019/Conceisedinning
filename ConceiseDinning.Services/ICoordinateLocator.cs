using System;
using System.Collections.Generic;
using System.Text;
using ConceiseDinning.Core.Models;

namespace ConceiseDinning.Services
{
    public interface ICoordinateLocator
    {
       GeocodeLocator GetRestarauntGeocodeCoordinates { get; set; }
    }
}
