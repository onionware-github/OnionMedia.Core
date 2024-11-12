﻿/*
 * Copyright (C) 2022 Jaden Phil Nebel (Onionware)
 *
 * This file is part of OnionMedia.
 * OnionMedia is free software: you can redistribute it and/or modify it under the terms of the GNU Affero General Public License as published by the Free Software Foundation, version 3.

 * OnionMedia is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU Affero General Public License for more details.

 * You should have received a copy of the GNU Affero General Public License along with OnionMedia. If not, see <https://www.gnu.org/licenses/>.
 */

namespace OnionMedia.Core.Services;
public interface IStringResourceService
{
    /// <summary>
    /// Resolves a string resource that gets localized with the given name.
    /// </summary>
    /// <param name="resourceName">The name of the resource to get.</param>
    /// <param name="sectionName">The file- or sectionname where the resource is stored. Use the default section on null.</param>
    /// <returns>The localized resource as a <see cref="string"/>.</returns>
    string GetLocalized(string resourceName, string sectionName = default);
}
