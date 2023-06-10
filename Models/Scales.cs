using System;
using System.Collections.Generic;

namespace FlightAPI.Models {

    public class Scales {

        public int Id { get; set; }
        public int ScalesNumbers { get; set; }
        public List<Stop> StopList { get; set; }

        public Scales() {
            StopList = new List<Stop>();
        }

        // Adiciona uma parada à lista de paradas
        public void AddStop(Stop stop) {
            StopList.Add(stop);
        }

        // Encontra uma parada na lista pelo Id e atualiza seus dados
        public void UpdateStop(int stopId, Stop updatedStop) {
            Stop stop = StopList.Find(s => s.Id == stopId);
            if (stop != null) {
                stop.Name = updatedStop.Name;
                stop.Sequence = updatedStop.Sequence;
            }
        }

        // Remove uma parada da lista pelo Id
        public void RemoveStop(int stopId) {
            Stop stop = StopList.Find(s => s.Id == stopId);
            if (stop != null) {
                StopList.Remove(stop);
            }
        }
    }

    public class Stop {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Sequence { get; set; }
    }
}
