// <copyright file="NumberPairMultiplierTest.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.Test.NumberMultiplier
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NineNineTable.NumberMultiplier;

    /// <summary>
    /// Tests <see cref="NumberPairMultiplier"/>.
    /// </summary>
    [TestClass]
    public class NumberPairMultiplierTest
    {
        /// <summary>
        /// Tests <see cref="NumberPairMultiplier.Result"/>.
        /// </summary>
        [TestMethod]
        public void TestResult()
        {
            new NumberPairMultiplier(3, 7).Result.Should().Be(21);
        }
    }
}
