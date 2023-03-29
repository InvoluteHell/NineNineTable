// <copyright file="IOutputFormatter.cs" company="Helloworld">
// Copyright (c) Helloworld. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
// </copyright>

namespace NineNineTable.OutputFormatter
{
    /// <summary>
    /// The output formatter.
    /// </summary>
    /// <typeparam name="T">The type of the item.</typeparam>
    public interface IOutputFormatter<T>
    {
        /// <summary>
        /// Gets the function to output a string.
        /// </summary>
        public Action<string?> OutputFunction { get; init; }

        /// <summary>
        /// Outputs an item.
        /// </summary>
        /// <param name="item">The item.</param>
        void Output(T item);
    }
}
