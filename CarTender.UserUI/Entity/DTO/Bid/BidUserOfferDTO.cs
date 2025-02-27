﻿using System;

namespace Entity.DTO.Bid
{
    public class BidUserOfferDTO
    {
        public Guid BidCorporateUserID { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
    }
}
