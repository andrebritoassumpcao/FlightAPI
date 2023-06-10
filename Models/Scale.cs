using System;


namespace FlightAPI.Models {

    public class Scale {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Sequence { get; set; }
        public int FlightId { get; set; }
    }

}
