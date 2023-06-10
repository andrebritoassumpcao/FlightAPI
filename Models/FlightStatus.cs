using System;

namespace FlightAPI.Models {
    public class FlightStatus {
        public bool FlightConfirmed { get; set; }
        public bool FlightDelay { get; set; }
        public bool FlightCanceled { get; set; }

        public string DelayReason { get; set; }
        public DateTime NewTime { get; set; }

        public string CancellationReason { get; set; }
        public DateTime Rebook { get; set; }

        public void ConfirmFlight(string reason) {
            FlightConfirmed = true;
            FlightDelay = false;
            FlightCanceled = false;
        }

        public void DelayFlight(string reason, DateTime newTime) {
            if (FlightConfirmed) {
                throw new InvalidOperationException("Não é possível atrasar um voo já confirmado.");
            }

            FlightConfirmed = false;
            FlightDelay = true;
            FlightCanceled = false;

            DelayReason = reason;
            NewTime = newTime;
        }

        public void CancelFlight(string reason, DateTime rebook) {
            if (FlightConfirmed) {
                throw new InvalidOperationException("Não é possível cancelar um voo já confirmado.");
            }

            FlightConfirmed = false;
            FlightDelay = false;
            FlightCanceled = true;

            CancellationReason = reason;
            Rebook = rebook;
        }
    }
}
