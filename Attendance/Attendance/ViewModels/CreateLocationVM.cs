﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Attendance.ViewModels
{
    public class CreateLocationVM
    {
        [Required]
        [StringLength(500)]
        public string Name { get; set; }

        public string Description { get; set; }
    }
}