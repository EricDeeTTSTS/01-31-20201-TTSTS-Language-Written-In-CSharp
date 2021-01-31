// <copyright file="UserStorageDevice.cs" company="EricDeeTTSTS.com">
// Copyright (c) EricDeeTTSTS.com. All rights reserved.
// </copyright>

namespace No_AccessClasses
{
    using System.Collections.Generic;
    using AccessTree.Interfaces;
    using HeapAccessClasses;
    using StackAccessClasses;

    /// <summary>
    /// Class definition for heap access via methods only.
    /// </summary>
    public class UserStorageDevice : IHeapAccessor
    {
        private int inputIndex;

        private Dictionary<int, List<string>> trackOfEvents;
        private List<List<string>> userInputAndEventContainer;
        private List<List<byte>> heapASCIICommands;

        private IContainer inputReference;
        private IVolatile inputBackEnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserStorageDevice"/> class.
        /// </summary>
        public UserStorageDevice()
        {
            this.inputIndex = 0;
            this.inputReference = new UserInputContents();
            this.inputBackEnd = new UserInputHost();
            this.trackOfEvents = new Dictionary<int, List<string>>();
            this.userInputAndEventContainer = new List<List<string>>();
            this.userInputAndEventContainer.Add(new List<string>());
            this.heapASCIICommands = new List<List<byte>>();
        }

        /// <summary>
        /// Allows for asynchronization via layering of Lists/arrays.
        /// </summary>
        /// <param name="contents">The interface which holds the contents.</param>
        /// <param name="text">The string to be converted.</param>
        public void SetEventAndIncrement(IHeapAccessor contents, string text)
        {
            this.userInputAndEventContainer[this.inputIndex].Add("Initialize");
            this.userInputAndEventContainer[this.inputIndex].Add(this.inputReference.StartStorageEvent(this.ReturnListFromText(text), this.inputIndex, contents.ReturnInputWithEventList(), this.inputBackEnd, this.heapASCIICommands));
            this.trackOfEvents.Add(this.inputIndex, contents.ReturnInputWithEventList());
            this.inputIndex++;
            contents.AddNewListForInput();
        }

        /// <summary>
        /// The same string gets returned as part of a list.
        /// This is used for compatibility and is a utility.
        /// </summary>
        /// <param name="text">The string to make compatible.</param>
        /// <returns>The string as a list.</returns>
        public List<string> ReturnListFromText(string text)
        {
            List<string> registerStrings = new List<string>();
            registerStrings.Add(text);
            return registerStrings;
        }

        /// <summary>
        /// Returns a list from the "inaccessible" contents.
        /// </summary>
        /// <returns>List of events from key value pairs matched to a instruction.</returns>
        public List<string> ReturnInputWithEventList()
        {
            return this.userInputAndEventContainer[(int)this.inputIndex];
        }

        /// <summary>
        /// Adds a new list to the events box so that the heap is available to future operations after completion of events.
        /// </summary>
        public void AddNewListForInput()
        {
            this.userInputAndEventContainer.Add(new List<string>());
        }
    }
}
