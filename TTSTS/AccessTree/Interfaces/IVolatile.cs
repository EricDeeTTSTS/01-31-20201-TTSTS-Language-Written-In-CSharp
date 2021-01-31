// <copyright file="IVolatile.cs" company="EricDeeTTSTS.com">
// Copyright (c) EricDeeTTSTS.com. All rights reserved.
// </copyright>

namespace AccessTree.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface to restrict excessive class access representing Random Access Memory (RAM) actions on the stack allocation space.
    /// </summary>
    public interface IVolatile
    {
        /// <summary>
        /// Method for converting strings to a decimal representation.
        /// </summary>
        /// <param name="stringsToConvert">The strings to convert.</param>
        /// <returns>String conversion to a decimal/ASCII list.</returns>
        public List<List<byte>> ConvertStringsToASCIIList(List<string> stringsToConvert);
    }
}