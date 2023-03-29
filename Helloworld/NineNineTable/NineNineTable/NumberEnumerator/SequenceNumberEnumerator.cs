// <copyright file="SequenceNumberEnumerator.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.NumberEnumerator
{
    using System.Collections;
    using System.Collections.Generic;

    /// <summary>
    /// The sequence number enumerator.
    /// </summary>
    public sealed class SequenceNumberEnumerator : INumberEnumerator
    {
        /// <summary>
        /// The starting value.
        /// </summary>
        private readonly int start;

        /// <summary>
        /// The ending value.
        /// </summary>
        private readonly int end;

        /// <summary>
        /// Initializes a new instance of the <see cref="SequenceNumberEnumerator"/> class.
        /// </summary>
        /// <param name="start">The starting value, inclusive.</param>
        /// <param name="end">The ending value, inclusive.</param>
        public SequenceNumberEnumerator(int start, int end)
        {
            this.start = start;
            this.end = end;
        }

        /// <inheritdoc/>
        IEnumerator<int> IEnumerable<int>.GetEnumerator()
        {
            return this.GetEnumeratorInternal();
        }

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumeratorInternal();
        }

        /// <summary>
        /// Gets enumerator.
        /// </summary>
        /// <returns>The enumerator.</returns>
        private IEnumerator<int> GetEnumeratorInternal()
        {
            return Enumerable.Range(this.start, this.end - this.start + 1).GetEnumerator();
        }
    }
}
