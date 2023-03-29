// <copyright file="NineNineTableData.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.OutputFormatter
{
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// The nine nine table data.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public record NineNineTableData
    {
        /// <summary>
        /// Gets or sets the multiplicand.
        /// </summary>
        public int Multiplicand { get; set; }

        /// <summary>
        /// Gets or sets the multiplier.
        /// </summary>
        public int Multiplier { get; set; }
    }
}
