﻿using SdvCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SdvCode.ViewModels.Home
{
    public class HomeViewModel
    {
        public int TotalRegisteredUsers { get; set; }

        public ICollection<ApplicationUser> Administrators { get; set; } = new HashSet<ApplicationUser>();
    }
}