﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SdvCode.Data;
using SdvCode.Models;
using SdvCode.Services;

namespace SdvCode.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IProfileService profileService;

        public ProfileController(UserManager<ApplicationUser> userManager, IProfileService profileService)
        {
            this.userManager = userManager;
            this.profileService = profileService;
        }

        [Authorize]
        [Route("/Profile/{username}")]
        public IActionResult Index(string username)
        {
            var currentUserId = this.userManager.GetUserId(HttpContext.User);
            ApplicationUser user = this.profileService.ExtractUserInfo(username, currentUserId);
            return View(user);
        }

        [Authorize]
        [Route("/Follow/{username}")]
        public IActionResult Follow(string username)
        {
            var currentUserId = this.userManager.GetUserId(HttpContext.User);
            ApplicationUser currentUser = this.profileService.FollowUser(username, currentUserId);

            return this.Redirect($"/Profile/{currentUser.UserName}");
        }

        [Authorize]
        [Route("/Unfollow/{username}")]
        public IActionResult Unfollow(string username)
        {
            var currentUserId = this.userManager.GetUserId(HttpContext.User);
            ApplicationUser currentUser = this.profileService.UnfollowUser(username, currentUserId);

            return this.Redirect($"/Profile/{currentUser.UserName}");
        }

        [Authorize]
        [Route("/Profile/AllUsers")]
        public IActionResult AllUsers()
        {
            return this.View();
        }
    }
}