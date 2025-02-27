﻿using System;

namespace Entity.DTO.Message
{
    public class MessageDTO
    {
        public Guid MessageContentID { get; set; }
        public Guid UserID { get; set; }
        public bool IsActive { get; set; }
        public TimeSpan? Version { get; set; }
    }
}
