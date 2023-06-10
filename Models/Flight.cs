using System;

namespace FlightAPI.Models {

    public class Flight {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public Aircraft Aircraft { get; set; }
        public FlightStatus Status { get; set; }

        public void AssignAircraft(Aircraft aircraft) {
            Aircraft = aircraft;

            if (aircraft.IsCapacityExceeded()) {
                Status.DelayFlight("Capacidade excedida", DateTime.Now);
            }
        }
    }
}


