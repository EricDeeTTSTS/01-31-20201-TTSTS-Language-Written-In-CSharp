// <copyright file="MainWindow.xaml.cs" company="EricDeeTTSTS.com">
// Copyright (c) EricDeeTTSTS.com. All rights reserved.
// </copyright>

/// <summary>
/// Sets up the general bus or namespace for the Language app.
/// </summary>

namespace TTSTS
{
    using System.Collections.Generic;
    using System.Windows;
    using AccessTree.Interfaces;
    using HeapAccessClasses;
    using StackAccessClasses;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        private int inputIndex;

        private string inputFromHistory;

        private UserInputContents contents;

        private IContainer inputReference;

        private IVolatile inputBackEnd;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.contents = new UserInputContents();

            this.inputIndex = 0;

            this.inputReference = new UserInputContents();

            this.inputBackEnd = new UserInputHost();

            this.InitializeComponent();

            this.PublicTextBoxOne.MaxLines = 90;

            this.PublicTextBoxOne.ScrollToEnd();

            this.PublicTextBoxOne.AcceptsReturn = true;

            this.PublicTextBoxOne.AcceptsTab = true;

            this.PublicTextBoxOne.TextWrapping = TextWrapping.Wrap;

            this.Title = "TTSTS Language";

            /* Debug conditions.
            *
            */

#if DEBUG
            this.Title += " [DEBUG MODE]";
#endif
        }

        /// <summary>
        /// Gets.
        /// </summary>
        public string GetInputFromHistory
        {
            get => this.inputFromHistory;
        }

        /// <summary>
        /// Sets.
        /// </summary>
        public string SetInputFromHistory
        {
            set => this.inputFromHistory = value;
        }

        private void FindRequest_Click(object sender, RoutedEventArgs e)
        {
            this.CallInputs_thenSetReference();
        }

        /// <summary>
        /// Application general functions.
        /// </summary>
        private void CallInputs_thenSetReference()
        {
            /* Gets the value from the text box named "PublicTextBoxOne". */

            /// <summary>
            /// As an interface, IContainer will operate on the main class, but not actually rely on it as a stack copy. It receives arguments from the stack, which is slightly more organized.
            /// </summary>

            this.SetEventAndIncrement();
        }

        /// <summary>
        /// Allows for asynchronization via layering of Lists/arrays.
        /// </summary>
        private void SetEventAndIncrement()
        {
            this.contents.UserInputAndEventContainer[this.inputIndex].Add("Initialize");
            this.contents.UserInputAndEventContainer[this.inputIndex].Add(this.inputReference.StartStorageEvent(this.ReturnPublicTextBoxOne(), this.inputIndex, this.contents.UserInputAndEventContainer[(int)this.inputIndex], this.inputBackEnd));
            this.contents.TrackOfEvents.Add(this.inputIndex, this.contents.UserInputAndEventContainer[(int)this.inputIndex]);
            this.inputIndex++;
            this.contents.UserInputAndEventContainer.Add(new List<string>());
        }

        private List<string> ReturnPublicTextBoxOne()
        {
            List<string> registerStrings = new List<string>();
            registerStrings.Add(this.PublicTextBoxOne.Text);
            return registerStrings;
        }
    }
}
