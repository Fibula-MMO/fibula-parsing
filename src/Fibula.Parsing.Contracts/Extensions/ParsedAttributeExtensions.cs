// -----------------------------------------------------------------
// <copyright file="ParsedAttributeExtensions.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Parsing.Contracts.Extensions
{
    using Fibula.Parsing.Contracts.Abstractions;
    using Fibula.Utilities.Validation;

    /// <summary>
    /// Static class containing extension methods for the <see cref="IParsedAttribute"/> interface.
    /// </summary>
    public static class ParsedAttributeExtensions
    {
        /// <summary>
        /// Evaluates whether the attritbute is really a flag, by checking if it has a value.
        /// </summary>
        /// <param name="attribute">The attribute to evaluate.</param>
        /// <returns>True if the attribute is a flag (has no value), and false otherwise.</returns>
        public static bool IsFlag(this IParsedAttribute attribute)
        {
            attribute.ThrowIfNull(nameof(attribute));

            return attribute.Value == null;
        }
    }
}
