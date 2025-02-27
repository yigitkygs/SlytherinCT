﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Entity.DTO.CarHistory
{
    public class AddCarHistoryDTO
    {
        [DisplayName("Araç Plakası")]
        public string CarPlate { get; set; }

        [DisplayName("Marka")]
        public string Brand { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }

        [DisplayName("Kurumsal Mı")]
        public bool IsCorporete { get; set; }

        [DisplayName("Araç Statüsü")]
        public List<string> CarStatus { get; set; }

        [DisplayName("Statü Düzenlenme Tarihi")]
        public DateTime StatusEditDate { get; set; }
    }
}
