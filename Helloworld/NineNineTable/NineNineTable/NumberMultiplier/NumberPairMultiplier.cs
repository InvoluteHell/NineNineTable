// <copyright file="NumberPairMultiplier.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.NumberMultiplier
{
    /// <summary>
    /// The number multiplier of a pair of numbers.
    /// </summary>
    public class NumberPairMultiplier : INumberMultiplier
    {
        /// <summary>
        /// The left hand side.
        /// </summary>
        private readonly int lhs;

        /// <summary>
        /// The right hand side.
        /// </summary>
        private readonly int rhs;

        /// <summary>
        /// Initializes a new instance of the <see cref="NumberPairMultiplier"/> class.
        /// </summary>
        /// <param name="lhs">The left hand side.</param>
        /// <param name="rhs">The right hand side.</param>
        public NumberPairMultiplier(int lhs, int rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        /// <inheritdoc/>
        public int Result => this.lhs * this.rhs;
    }
}
