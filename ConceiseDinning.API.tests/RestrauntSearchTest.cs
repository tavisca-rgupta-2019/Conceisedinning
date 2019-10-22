using System;
using System.Collections.Generic;
using Xunit;
using ConceiseDinning.API.Controllers;
using ConceiseDinning.Adapter.Geocoder.xyz.Models;

namespace ConceiseDinning.API.tests
{
    public class RestraunttSearchTest
    {
        [Fact]
        public void when_Given_Valid_LocalityVerbose()
        {
            //given
            string CityVerbose = "Rajiv Chowk Delhi";
            List<double> actual = new List<double>() { 77.22063, 28.63357 };
            //when
            List<double> expected = new List<double>() { };
            RestrauntSearchController restrauntSearch = new RestrauntSearchController();
            RestarauntGeocodeLocator restarauntGeocodeLocator = new RestarauntGeocodeLocator();
            expected.Add(restarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(CityVerbose).Longitude);
            expected.Add(restarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(CityVerbose).Latitude);

            //then
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void when_given_invalid_LocalityVerbose()
        {
            //given
            string CityVerbose = "gsdhjsdfbhjdfhdvsjf bbmcdsbbhjb";
            List<double> actual = new List<double>() {0.00,0.00 };
            //when

            List<double> expected = new List<double>() {  };
            RestrauntSearchController restrauntSearch = new RestrauntSearchController();
            RestarauntGeocodeLocator restarauntGeocodeLocator = new RestarauntGeocodeLocator();
            expected.Add(restarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(CityVerbose).Longitude);
            expected.Add(restarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(CityVerbose).Latitude);

            //then
            Assert.Equal(expected, actual);
        }
    }
}
