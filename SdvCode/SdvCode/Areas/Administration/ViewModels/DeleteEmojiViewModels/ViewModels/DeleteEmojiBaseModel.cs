﻿// Copyright (c) SDV Code Project. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace SdvCode.Areas.Administration.ViewModels.DeleteEmojiViewModels.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using SdvCode.Areas.Administration.ViewModels.DeleteEmojiViewModels.InputModels;

    public class DeleteEmojiBaseModel
    {
        public DeleteEmojiInputModel DeleteEmojiInputModel { get; set; } = new DeleteEmojiInputModel();

        public ICollection<DeleteEmojiViewModel> DeleteEmojiViewModels { get; set; } =
            new HashSet<DeleteEmojiViewModel>();
    }
}