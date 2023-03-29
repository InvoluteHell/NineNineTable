// <copyright file="SequenceNumberEnumeratorTest.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.Test.NumberEnumerator
{
    using System.Collections;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NineNineTable.NumberEnumerator;

    /// <summary>
    /// Tests <see cref="SequenceNumberEnumerator"/>.
    /// </summary>
    [TestClass]
    public class SequenceNumberEnumeratorTest
    {
        /// <summary>
        /// Tests <see cref="IEnumerable.GetEnumerator"/>.
        /// </summary>
        [TestMethod]
        public void TestGetEnumerator()
        {
            new SequenceNumberEnumerator(1, 9).Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }

        /// <summary>
        /// Tests <see cref="IEnumerable{T}.GetEnumerator"/>.
        /// </summary>
        [TestMethod]
        public void TestGetEnumeratorGeneric()
        {
            ((IEnumerable<int>)new SequenceNumberEnumerator(1, 9)).GetEnumerator().Should().BeEquivalentTo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }
    }
}
