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
    public class MonsterSpellRule : ActionRule
    {
        /// <summary>
        /// A type for this rule.
        /// </summary>
        public const string RuleType = nameof(MonsterSpellRule);

        /// <summary>
        /// Initializes a new instance of the <see cref="MonsterSpellRule"/> class.
        /// </summary>
        /// <param name="conditions">The conditions for the spell.</param>
        /// <param name="effects">The effects of the spell.</param>
        /// <param name="chance">The chance of the spell.</param>
        public MonsterSpellRule(IEnumerable<string> conditions, IEnumerable<string> effects, string chance)
            : base(conditions, effects, MonsterSpellRule.RuleType)
        {
            if (!byte.TryParse(chance, out byte parsedChance))
            {
                throw new ArgumentException("The chance for the spell is invalid.", nameof(chance));
            }

            this.Chance = parsedChance;
        }

        /// <summary>
        /// Gets the chance of this spell being picked in a round.
        /// </summary>
        public byte Chance { get; }
    }
}
