using System.Windows;
using System.Windows.Threading;

namespace Chain_of_Responsibility_Exceptions
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }

        void App_DispatcherUnhandledException(object sender,
            DispatcherUnhandledExceptionEventArgs e)
        {
            try
            {
                // TODO: Log the exception and alert the support team
                e.Handled = true;
                MessageBox.Show("Something bad happened. Please contact the Help Desk for more information.");
                Application.Current.Shutdown();
            }
            catch
            {
                // If we get an exception in our unhandled exception handler, there's
                // not much we can do.
            }
        }
    }
}
