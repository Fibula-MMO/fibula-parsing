﻿// -----------------------------------------------------------------
// <copyright file="IParsedAttribute.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Parsing.Contracts.Abstractions
{
    /// <summary>
    /// Interface for a parsed attribute.
    /// </summary>
    public interface IParsedAttribute : IParsedFlag
    {
        /// <summary>
        /// Gets or sets the attribute's value.
        /// </summary>
        object Value { get; set; }
    }
}
