// <copyright file="MainWindow.xaml.cs" company="EricDeeTTSTS.com">
// Copyright (c) EricDeeTTSTS.com. All rights reserved.
// </copyright>

/// <summary>
/// Sets up the general bus or namespace for the Language app.
/// </summary>

namespace TTSTS
{
    using System.Windows;
    using AccessTree.Interfaces;
    using No_AccessClasses;

    /// <summary>
    /// Interaction logic for MainWindow.xaml.
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHeapAccessor contents;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.contents = new UserStorageDevice();

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

            this.contents.SetEventAndIncrement(this.contents, this.PublicTextBoxOne.Text);
        }
    }
}
