using System;

namespace FlightAPI.Models {
    public class Aircraft {
        public int Id { get; set; }
        public string Model { get; set; }
        public int PassengerCapacity { get; set; }
        public float CargoCapacity { get; set; }
        public float CargoQuantity { get; set; }
        public int PassangerQuantity { get; set; }

        public void PostAircraft() {
            // Implemente a lógica para adicionar um novo avião aqui
        }

        public void PatchAircraft() {
            // Implemente a lógica para atualizar um avião aqui
        }

        public void GetAircraft() {
            // Implemente a lógica para obter informações de um avião aqui
        }

        public void DeleteAircraft() {
            // Implemente a lógica para excluir um avião aqui
        }

        public bool IsCapacityExceeded() {
            if (CargoCapacity < CargoQuantity || PassengerCapacity < PassangerQuantity) {
                return true;
            }

            return false; // Adicione esse retorno para todos os caminhos possíveis
        }
    }
}
