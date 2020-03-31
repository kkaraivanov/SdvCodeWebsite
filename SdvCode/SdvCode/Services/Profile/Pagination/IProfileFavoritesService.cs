﻿// Copyright (c) SDV Code Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SdvCode.Services.Profile.Pagination
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using SdvCode.Models.User;
    using SdvCode.ViewModels.Profile;

    public interface IProfileFavoritesService
    {
        Task<List<FavoritesViewModel>> ExtractFavorites(ApplicationUser user, ApplicationUser currentUser);
    }
}