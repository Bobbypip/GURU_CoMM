﻿using System.ComponentModel.DataAnnotations;

namespace GURU_CoMM.Entities
{
    public class Pet
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
