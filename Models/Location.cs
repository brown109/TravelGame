﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelGame.Models
{
    //
    // A location is a city that you must visit to complete the game. Data is hard-coded and will be read from a file in subsequent builds.
    // From any given city, you can go to other cities if they show up in the directional city names. For example, this game requires a visit to London and Warsaw.
    // Warsaw is East of London so the location for London has "Warsaw" loaded in ECity and the Location for Warsaw has "London" loaded in WCity.
    // As you can see, there are 8 different directions and the presence of a value in these directional cities triggers a corresponding directional button
    // to appear on the control window so the player will click SW to move to the city that is Southwest of his/her current location. And of course, a NE button should  
    // show on the new city to take you back.
    //
    public class Location : ObservableObject
    {
        private string _city;
        private string _ncity;
        private string _scity;
        private string _ecity;
        private string _wcity;
        private string _necity;
        private string _nwcity;
        private string _secity;
        private string _swcity;
        public string City
        {
            get { return _city; }
            set { _city = value;
                OnPropertyChanged(nameof(City));
            }
        }
        public string NCity
        {
            get { return _ncity; }
            set { _ncity = value; }
        }
        public string SCity
        {
            get { return _scity; }
            set { _scity = value; }
        }
        public string ECity
        {
            get { return _ecity; }
            set { _ecity = value; }
        }
        public string WCity
        {
            get { return _wcity; }
            set { _wcity = value; }
        }
        public string NECity
        {
            get { return _necity; }
            set { _necity = value; }
        }
        public string NWCity
        {
            get { return _nwcity; }
            set { _nwcity = value; }
        }
        public string SECity
        {
            get { return _secity; }
            set { _secity = value; }
        }
        public string SWCity
        {
            get { return _swcity; }
            set { _swcity = value; }
        }
        public Location()
        {

        }
        public Location(string city, string ncity, string scity, string ecity, string wcity, string necity, string nwcity, string secity, string swcity)
        {
            _city = city;
            _ncity = ncity;
            _scity = scity;
            _ecity = ecity;
            _wcity = wcity;
            _necity = necity;
            _nwcity = nwcity;
            _secity = secity;
            _swcity = swcity;
        }
    }
}
