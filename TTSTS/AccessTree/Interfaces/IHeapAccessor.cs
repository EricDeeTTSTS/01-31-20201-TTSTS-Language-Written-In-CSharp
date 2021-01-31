// <copyright file="IHeapAccessor.cs" company="EricDeeTTSTS.com">
// Copyright (c) EricDeeTTSTS.com. All rights reserved.
// </copyright>

namespace AccessTree.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Keeps contents inaccessible.
    /// </summary>
    public interface IHeapAccessor
    {
        /// <summary>
        /// Allows for asynchronization via layering of Lists/arrays.
        /// </summary>
        /// <param name="contents">The interface which holds the contents.</param>
        /// <param name="text">The string to be converted.</param>
        public void SetEventAndIncrement(IHeapAccessor contents, string text);

        /// <summary>
        /// The same string gets returned as part of a list.
        /// This is used for compatibility and is a utility.
        /// </summary>
        /// <param name="text">The string to make compatible.</param>
        /// <returns>The string as a list.</returns>
        public List<string> ReturnListFromText(string text);

        /// <summary>
        /// Returns a list from the "inaccessible" contents.
        /// </summary>
        /// <returns>List of events from key value pairs matched to a instruction.</returns>
        public List<string> ReturnInputWithEventList();

        /// <summary>
        /// Adds a new list to the events box so that the heap is available to future operations after completion of events.
        /// </summary>
        public void AddNewListForInput();
    }
}
