﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DamThanhNgan_17.Models
{
    public class Account
    {
        [Key]
        public string Username { get; set; }
        public string Passwork { get; set; }
    }
}