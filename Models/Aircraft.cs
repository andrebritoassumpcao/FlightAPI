using System;

namespace FlightAPI.Models;
    public class Aircraft {
        public int Id { get; set; }
        public string Model { get; set; }
        public int PassengerCapacity { get; set; }
        public float CargoCapacity { get; set; }
        public float CargoQuantity { get; set; }
        public int PassangerQuantity { get; set; }
    }

