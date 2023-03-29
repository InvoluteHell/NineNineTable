// <copyright file="NineNineTableConsoleOutputFormatter.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.OutputFormatter
{
    using System;

    /// <summary>
    /// The output formatter for nine nine table.
    /// </summary>
    public class NineNineTableConsoleOutputFormatter : IOutputFormatter<NineNineTableData>
    {
        /// <summary>
        /// The item separator.
        /// </summary>
        private const string Separator = " ";

        /// <summary>
        /// The formatter to format the item to string.
        /// </summary>
        private readonly Func<NineNineTableData, string> formatter;

        /// <summary>
        /// The last multiplicand. When it changes, output a newline first.
        /// </summary>
        private int lastMultiplicand;

        /// <summary>
        /// Initializes a new instance of the <see cref="NineNineTableConsoleOutputFormatter"/> class.
        /// </summary>
        /// <param name="formatter">The formatter to format the item to string.</param>
        public NineNineTableConsoleOutputFormatter(Func<NineNineTableData, string> formatter)
        {
            this.formatter = formatter;
        }

        /// <inheritdoc/>
        public Action<string?> OutputFunction { get; init; } = Console.Write;

        /// <inheritdoc/>
        public void Output(NineNineTableData item)
        {
            item = item ?? throw new ArgumentNullException(nameof(item));

            if (this.lastMultiplicand != 0 && this.lastMultiplicand != item.Multiplicand)
            {
                this.OutputFunction(Environment.NewLine);
            }

            this.lastMultiplicand = item.Multiplicand;
            this.OutputFunction(this.formatter(item));
            this.OutputFunction(Separator);
        }
    }
}
