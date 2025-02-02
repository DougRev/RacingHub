﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingHub.Data
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        public Guid OwnerId { get; set; }

        [Required]
        public string TeamName { get; set; }
        public string TeamDescription { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}
