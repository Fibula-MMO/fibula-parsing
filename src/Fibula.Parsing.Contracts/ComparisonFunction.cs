// -----------------------------------------------------------------
// <copyright file="ComparisonFunction.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Parsing.Contracts
{
    using System;
    using Fibula.Parsing.Contracts.Enumerations;

    /// <summary>
    /// Class that represents a function that is a comparison to a value or constant.
    /// </summary>
    public class ComparisonFunction
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComparisonFunction"/> class.
        /// </summary>
        /// <param name="name">The name of the function.</param>
        /// <param name="operator">The comparison operator.</param>
        /// <param name="constantOrValue">The constant or value being compared against.</param>
        /// <param name="parameters">The parameters of the function.</param>
        public ComparisonFunction(string name, string @operator, string constantOrValue, params string[] parameters)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
            this.ConstantOrValue = constantOrValue ?? throw new ArgumentNullException(nameof(constantOrValue));
            this.Parameters = parameters;

            this.Operator = @operator switch
            {
                ">=" => ComparisonOperator.GreaterThanOrEqual,
                "<=" => ComparisonOperator.LessThanOrEqual,
                ">" => ComparisonOperator.GreaterThan,
                "<" => ComparisonOperator.LessThan,
                "==" => ComparisonOperator.Equal,
                _ => throw new NotSupportedException($"Unsupported value for {nameof(@operator)}: '{@operator}'.")
            };
        }

        /// <summary>
        /// Gets the name of the function.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Gets the parameters of the function.
        /// </summary>
        public string[] Parameters { get; }

        /// <summary>
        /// Gets the type of comparison to the <see cref="ConstantOrValue"/>.
        /// </summary>
        public ComparisonOperator Operator { get; }

        /// <summary>
        /// Gets the constant or value to compare against.
        /// </summary>
        public string ConstantOrValue { get; }
    }
}
