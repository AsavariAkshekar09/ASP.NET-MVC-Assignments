﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CFAAssignment1.Models
{
 
    public class FootBallLeague
    {
        [Key]
        [Required]
        public int MatchID { get; set; }
        [Required]
        public string TeamName1 { get; set; }
        [Required]
        public string TeamName2 { get; set; }
        [Required]
        public string MatchStatus { get; set; }
        public string WinningTeam { get; set; }
        [Required]
        public int Points { get; set; }
    }
}