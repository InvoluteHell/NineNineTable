// <copyright file="Program.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable
{
    using System.Diagnostics.CodeAnalysis;
    using NineNineTable.NumberEnumerator;
    using NineNineTable.NumberMultiplier;
    using NineNineTable.OutputFormatter;

    /// <summary>
    /// The main program.
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal sealed class Program
    {
        /// <summary>
        /// The starting value of nine nine table.
        /// </summary>
        private const int NineNineTableStartingValue = 1;

        /// <summary>
        /// The ending value of nine nine table.
        /// </summary>
        private const int NineNineTableEndingValue = 9;

        /// <summary>
        /// The main function.
        /// </summary>
        /// <param name="args">The arguments.</param>
        internal static void Main(string[] args)
        {
            INumberEnumerator multiplicandEnumerator = new SequenceNumberEnumerator(NineNineTableStartingValue, NineNineTableEndingValue);

            IOutputFormatter<NineNineTableData> outputFormatter = new NineNineTableConsoleOutputFormatter(data => $"{data.Multiplicand}*{data.Multiplier}={new NumberPairMultiplier(data.Multiplicand, data.Multiplier).Result}");

            var nineNineTable = multiplicandEnumerator
                .SelectMany(multiplicand => new SequenceNumberEnumerator(NineNineTableStartingValue, multiplicand).Select(multiplier => (multiplicand, multiplier)))
                .Select(pair => new NineNineTableData()
                {
                    Multiplicand = pair.multiplicand,
                    Multiplier = pair.multiplier,
                });

            foreach (var item in nineNineTable)
            {
                outputFormatter.Output(item);
            }
        }
    }
}