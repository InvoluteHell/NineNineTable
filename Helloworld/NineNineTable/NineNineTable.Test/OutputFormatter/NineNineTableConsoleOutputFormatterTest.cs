// <copyright file="NineNineTableConsoleOutputFormatterTest.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.Test.OutputFormatter
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NineNineTable.OutputFormatter;

    /// <summary>
    /// Tests <see cref="NineNineTableConsoleOutputFormatter"/>.
    /// </summary>
    [TestClass]
    public class NineNineTableConsoleOutputFormatterTest
    {
        /// <summary>
        /// Tests <see cref="NineNineTableConsoleOutputFormatter.Output(NineNineTableData)"/>.
        /// </summary>
        [TestMethod]
        public void TestOutput()
        {
            var output = string.Empty;

            var formatter = new NineNineTableConsoleOutputFormatter(data => $"{data.Multiplicand}*{data.Multiplier}={data.Multiplicand * data.Multiplier}")
            {
                OutputFunction = value => output += value,
            };

            formatter.Output(new NineNineTableData()
            {
                Multiplicand = 1,
                Multiplier = 1,
            });

            output.Should().Be("1*1=1 ");
        }

        /// <summary>
        /// Tests <see cref="NineNineTableConsoleOutputFormatter.Output(NineNineTableData)"/> with multi-line outputs.
        /// </summary>
        [TestMethod]
        public void TestOutputMultiline()
        {
            var output = string.Empty;

            var formatter = new NineNineTableConsoleOutputFormatter(data => $"{data.Multiplicand}*{data.Multiplier}={data.Multiplicand * data.Multiplier}")
            {
                OutputFunction = value => output += value,
            };

            for (int i = 0; i < 9; i++)
            {
                formatter.Output(new NineNineTableData()
                {
                    Multiplicand = i + 1,
                    Multiplier = 1,
                });
            }

            output.Should().Contain(Environment.NewLine);
        }

        /// <summary>
        /// Tests <see cref="NineNineTableConsoleOutputFormatter.Output(NineNineTableData)"/> with null value.
        /// </summary>
        [TestMethod]
        public void TestOutputNull()
        {
            var formatter = new NineNineTableConsoleOutputFormatter(data => string.Empty)
            {
                OutputFunction = _ => { },
            };

            Action a = () => formatter.Output(default!);
            a.Should().Throw<ArgumentNullException>();
        }
    }
}
