using System;

namespace FlightAPI.Models;
    public class Flight {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
    }

