// <copyright file="NineNineTableConsoleOutputFormatter.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.OutputFormatter
{
    using System;
    using NineNineTable.NumberMultiplier;

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
        /// The count of items printed. When it reaches 9, output a newline and reset this to 0.
        /// </summary>
        private int count;

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
            this.OutputFunction(this.formatter(item));
            this.count++;

            if (this.count >= 9)
            {
                this.OutputFunction(Environment.NewLine);
                this.count = 0;
            }
            else
            {
                this.OutputFunction(Separator);
            }
        }
    }
}
