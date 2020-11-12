﻿// Copyright (c) SDV Code Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SdvCode.Areas.Administration.ViewModels.DeleteChatTheme.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SdvCode.Areas.Administration.ViewModels.DeleteChatTheme.InputModels;

    public class DeleteChatThemeBaseViewModel
    {
        public ICollection<DeleteChatThemeViewModel> DeleteChatThemeView { get; set; } = new HashSet<DeleteChatThemeViewModel>();

        public DeleteChatThemeInputModel DeleteChatThemeInputModel { get; set; } =
            new DeleteChatThemeInputModel();
    }
}