/// <summary>
/// The Trees namespace.
/// </summary>
namespace Trees
{
    using System;
    using System.Windows;
    using System.Windows.Threading;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            this.InitializeComponent();
            this.DataContext = new MainViewModel();

            this.inBox.TextChanged += (sender, e) =>
                {
                    if (string.IsNullOrEmpty(this.inBox.Text))
                    {
                        this.inBox.Focus();
                    }
                };

            Application.Current.Dispatcher.BeginInvoke(
                new Action(
                    () =>
                        {
                            this.inBox.Focus();
                            this.inBox.SelectAll();
                        }),
                DispatcherPriority.ApplicationIdle);
        }

        #endregion
    }
}