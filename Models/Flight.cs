using System;
using FlightAPI.Models;

namespace FlightAPI.Models {

    public class Flight {
        public int Id { get; set; }
        public int FlightNumber { get; set; }
        public string? Origin { get; set; }
        public string? Destination { get; set; }
        public DateTime ArrivalTime {get; set;}
        public DateTime DepartureTime {get; set;}
        public Aircraft? AssignedAircraft { get; set; }
        public FlightStatus? Status { get; set; }
        public bool HasScales { get; set; }
        public List<Scale> Scales { get; set; }

        public Flight()
        {
            Scales = new List<Scale>();
        }

        public void PostFlight()
        {
            
        }

        public void GetFlight()
        {

        }

        public void PatchFlight()
        {

        }
        public void DeleteFlight()
        {

        }

    public void AddScale(Scale scale)
        {
            if (Scales.Any(s => s.Id == scale.Id))
            {
                throw new Exception("Escala já adicionada ao voo.");
            }

            scale.FlightId = Id; // Definir o idFlight da escala como o ID do voo atual
            Scales.Add(scale);
            HasScales = true; // Definir hasScales como verdadeiro
        }

        public void PatchScale(int scaleId, Scale updatedScale)
        {
            Scale? scale = Scales.FirstOrDefault(s => s.Id == scaleId);

            if (scale == null)
            {
                throw new Exception("Escala não encontrada no voo.");
            }

            if (scale.FlightId != Id)
            {
                throw new Exception("Escala não pertence ao voo atual.");
            }

            scale.Name = updatedScale.Name;
            scale.Sequence = updatedScale.Sequence;
        }

        public void RemoveScale(int scaleId)
        {
            Scale? scale = Scales.FirstOrDefault(s => s.Id == scaleId);

            if (scale == null)
            {
                throw new Exception("Escala não encontrada no voo.");
            }

            if (scale.FlightId != Id)
            {
                throw new Exception("Escala não pertence ao voo atual.");
            }

            Scales.Remove(scale);
        }


        public void SetAssignedAircraft(Aircraft aircraft, FlightStatus? status) {
            AssignedAircraft = aircraft;

            if (aircraft.IsCapacityExceeded()) {
                status?.DelayFlight("Capacidade excedida", DateTime.Now);
            }
        }

        public FlightStatus? GetFlightStatus()
        {
            return Status;
        }

        public void PatchFlightStatus(FlightStatus status) {
            Status = status;
        }

        public void PostFlightStatus(FlightStatus status) {
            Status = status;
        }
    }
}


