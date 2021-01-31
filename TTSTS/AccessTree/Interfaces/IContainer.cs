// <copyright file="IContainer.cs" company="EricDeeTTSTS.com">
// Copyright (c) EricDeeTTSTS.com. All rights reserved.
// </copyright>

namespace AccessTree.Interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface to restrict excessive class access representing container actions on the heap allocation space.
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// This method should allow the programmer to operate on the "main heap" variables from the stack; allowing for greater optimization.
        /// </summary>
        /// <param name="variable">Expected string to add.</param>
        /// <param name="index">The index needed for placement of the string.</param>
        /// <param name="userInputContainer">The container or list to place the string into.</param>
        /// <param name="inputBackEnd">The method class holding the operations to use.</param>
        /// <returns>Event success or failure message.</returns>
        public string StartStorageEvent(List<string> variable, int index, List<string> userInputContainer, IVolatile inputBackEnd);
    }
}
