// <copyright file="AbstractUserInputHost.cs" company="EricDeeTTSTS.com">
// Copyright (c) EricDeeTTSTS.com. All rights reserved.
// </copyright>

namespace AccessTree.AbstractAccessClasses
{
    using System.Collections.Generic;
    using AccessTree.Interfaces;

    /// <summary>
    /// An abastract representation of many methods for user input receipt and retrieval.
    /// </summary>
    public abstract class AbstractUserInputHost
    {
        /// <summary>
        /// This method should allow the programmer to operate on the "main heap" variables from the stack; allowing for greater optimization.
        /// </summary>
        /// <param name="variable">Expected string to add.</param>
        /// <param name="index">The index needed for placement of the string.</param>
        /// <param name="userInputContainer">The container or list to place the string into.</param>
        /// <param name="inputBackEnd">The method class holding the operations to use.</param>
        /// <param name="heapASCIICommands">The resulting ASCII or decimal list.</param>
        /// <returns>Event success or failure message.</returns>
        public string StartStorageEvent(List<string> variable, int index, List<string> userInputContainer, IVolatile inputBackEnd, List<List<byte>> heapASCIICommands)
        {
            /// <summary>
            /// Stack control/obfuscation.
            /// </summary>
            int specifiedIndex = 0;
            uint specifiedCount = (uint)variable.Count;
            string eventHandled = "No operation completed";

            foreach (string variableString in variable)
            {
                foreach (string registerString in userInputContainer)
                {
                    if (specifiedIndex >= specifiedCount)
                    {
                        break;
                    }

                    if (index - specifiedIndex == 0)
                    {
                        userInputContainer[specifiedIndex] = variable[specifiedIndex];
                        eventHandled = $"The index you supplied was valid, and your variable was stored at index [{specifiedIndex}], [{index}]";
                        break;
                    }
                    else
                    {
                        userInputContainer[specifiedIndex] = variable[specifiedIndex];
                        eventHandled = $"The index you entered defaulted and your variable was stored at index [{index}], [{specifiedIndex}]";
                    }

                    specifiedIndex++;
                    break;
                }
            }

            List<List<byte>> registerASCIICommands = inputBackEnd.ConvertStringsToASCIIList(variable);

            foreach (List<byte> list in registerASCIICommands)
            {
                heapASCIICommands.Add(list);
            }

            return eventHandled;
        }

        /// <summary>
        /// Method for converting strings to a decimal representation.
        /// </summary>
        /// <param name="stringsToConvert">The strings to convert.</param>
        /// <returns>String conversion to a decimal/ASCII list.</returns>
        public List<List<byte>> ConvertStringsToASCIIList(List<string> stringsToConvert)
        {
            List<List<byte>> registerASCIICommandsList = new List<List<byte>>();
            List<byte> registerASCIIList = new List<byte>();
            int stringLength;

            foreach (string stringToConvert in stringsToConvert)
            {
                stringLength = stringToConvert.Length;

                for (int index = 0; index < stringLength; index++)
                {
                    registerASCIIList.Add((byte)stringToConvert[index]);
                }

                registerASCIICommandsList.Add(registerASCIIList);
            }

            return registerASCIICommandsList;
        }

        // Make list, then scan backwards until slash
        // Argument of speed vs validation
    }
}
