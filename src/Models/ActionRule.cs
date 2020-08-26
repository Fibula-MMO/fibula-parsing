// -----------------------------------------------------------------
// <copyright file="ActionRule.cs" company="2Dudes">
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
    using System.Linq;

    /// <summary>
    /// Class that represents an action rule.
    /// </summary>
    public class ActionRule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRule"/> class.
        /// </summary>
        /// <param name="conditions">The conditions of this rule.</param>
        /// <param name="actions">The actions of this rule.</param>
        /// <param name="type">Optional. The type of rule, if any is set.</param>
        public ActionRule(IEnumerable<string> conditions, IEnumerable<string> actions, string type = "")
        {
            this.ConditionSet = conditions ?? throw new ArgumentNullException(nameof(conditions));

            if (!this.ConditionSet.Any())
            {
                throw new ArgumentException($"The rule must contain at least one condition.", nameof(conditions));
            }

            this.ActionSet = actions ?? throw new ArgumentNullException(nameof(actions));

            if (!this.ActionSet.Any())
            {
                throw new ArgumentException($"The rule must contain at least one action.", nameof(actions));
            }

            this.Type = type;
        }

        /// <summary>
        /// Gets the type of event.
        /// </summary>
        public string Type { get; }

        /// <summary>
        /// Gets the set of conditions for this rule.
        /// </summary>
        public IEnumerable<string> ConditionSet { get; }

        /// <summary>
        /// Gets the set of actions for this rule.
        /// </summary>
        public IEnumerable<string> ActionSet { get; }
    }
}
