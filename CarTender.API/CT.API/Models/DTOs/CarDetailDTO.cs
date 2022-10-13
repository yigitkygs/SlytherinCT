﻿using System.Collections.Generic;

namespace CT.API.Models.DTOs
{
    public class CarDetailDTO
    {
        public List<string> BodyType { get; set; }
        public List<string> FuelType { get; set; }
        public List<string> GearType { get; set; }
        public List<string> Color { get; set; }
    }
}
