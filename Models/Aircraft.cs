using System;

namespace FlightAPI.Models {
    public class Aircraft {
        public int Id { get; set; }
        public string? Model { get; set; }
        public int PassengerCapacity { get; set; }
        public float CargoCapacity { get; set; }
        public float CargoQuantity { get; set; }
        public int PassangerQuantity { get; set; }

        public void PostAircraft() {
            // Implemente a logica para adicionar um novo aviao aqui
        }

        public void PatchAircraft() {
            // Implemente a logica para atualizar um aviao aqui
        }

        public void GetAircraft() {
            // Implemente a logica para obter informacoes de um aviso aqui
        }

        public void DeleteAircraft() {
            // Implemente a logica para excluir um aviao aqui
        }

        public bool IsCapacityExceeded() {
            if (CargoCapacity < CargoQuantity || PassengerCapacity < PassangerQuantity) {
                return true;
            }

            return false; 
        }
    }
}
