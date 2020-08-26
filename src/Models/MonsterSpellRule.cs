// -----------------------------------------------------------------
// <copyright file="MonsterSpellRule.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Parsing.Contracts.Models
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Class that represents a monster spell rule.
    /// </summary>
    public class MonsterSpellRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonsterSpellRule"/> class.
        /// </summary>
        /// <param name="conditions">The conditions for the spell.</param>
        /// <param name="effects">The effects of the spell.</param>
        /// <param name="chance">The chance of the spell.</param>
        public MonsterSpellRule(IEnumerable<string> conditions, IEnumerable<string> effects, string chance)
        {
            this.Conditions = conditions ?? throw new ArgumentNullException(nameof(conditions));
            this.Effects = effects ?? throw new ArgumentNullException(nameof(effects));

            if (!byte.TryParse(chance, out byte parsedChance))
            {
                throw new ArgumentException(nameof(chance));
            }

            this.Chance = parsedChance;
        }

        /// <summary>
        /// Gets the set of conditions for this rule.
        /// </summary>
        public IEnumerable<string> Conditions { get; }

        /// <summary>
        /// Gets the set of actions for this rule.
        /// </summary>
        public IEnumerable<string> Effects { get; }

        /// <summary>
        /// Gets the chance of this spell being picked.
        /// </summary>
        public byte Chance { get; }
    }
}
