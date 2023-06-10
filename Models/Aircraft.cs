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
            // Implemente a l�gica para adicionar um novo avi�o aqui
        }

        public void PatchAircraft() {
            // Implemente a l�gica para atualizar um avi�o aqui
        }

        public void GetAircraft() {
            // Implemente a l�gica para obter informa��es de um avi�o aqui
        }

        public void DeleteAircraft() {
            // Implemente a l�gica para excluir um avi�o aqui
        }

        public bool IsCapacityExceeded() {
            if (CargoCapacity < CargoQuantity || PassengerCapacity < PassangerQuantity) {
                return true;
            }

            return false; 
        }
    }
}
