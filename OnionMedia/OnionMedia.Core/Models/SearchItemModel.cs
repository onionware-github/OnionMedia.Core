﻿/*
 * Copyright (C) 2022 Jaden Phil Nebel (Onionware)
 *
 * This file is part of OnionMedia.
 * OnionMedia is free software: you can redistribute it and/or modify it under the terms of the GNU Affero General Public License as published by the Free Software Foundation, version 3.

 * OnionMedia is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details.

 * You should have received a copy of the GNU Affero General Public License along with OnionMedia. If not, see <https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode.Common;
using YoutubeExplode.Videos;

namespace OnionMedia.Core.Models
{
    public readonly record struct SearchItemModel
    {
        public SearchItemModel(IVideo video)
        {
            Title = video.Title;
            Author = video.Author.Title;
            Duration = video.Duration;
            Url = video.Url;
            ThumbnailUrl = video.Thumbnails.GetWithHighestResolution().Url;
        }

        public string Title { get; }
        public string Author { get; }
        public TimeSpan? Duration { get; }

        public string Url { get; }
        public string ThumbnailUrl { get; }
    }
}
