﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI_JqGrid.Models
{
    public class Pupil
    {

        public int PupilId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public long Age { get; set; }

        public virtual PupilDetail PupilDetail { get; set; }



    }
}