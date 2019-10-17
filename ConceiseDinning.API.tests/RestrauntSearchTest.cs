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
            //when
            List<double> actual = new List<double>() { 77.21751, 28.65673 };
            RestrauntSearchController restrauntSearch = new RestrauntSearchController();
            
            //then
            Assert.Equal(RestarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(CityVerbose), actual);

        }
        [Fact]
        public void when_given_invalid_LocalityVerbose()
        {
            //given
            string CityVerbose = "gsdhjsdfbhjdfhdvsjf bbmcdsbbhjb";
            //when
            List<double> actual = new List<double>() {};
            RestrauntSearchController restrauntSearch = new RestrauntSearchController();

            //then
            Assert.Equal(RestarauntGeocodeLocator.GetRestarauntGeocodeCoordinates(CityVerbose), actual);
        }
    }
}
