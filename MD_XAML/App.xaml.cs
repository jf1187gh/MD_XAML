using System.Configuration;
using System.Data;
using System.Windows;

namespace MD_XAML
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entry? MainWindowInstance { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            //RenderOptions.ProcessRenderMode = RenderMode.SoftwareOnly;
            base.OnStartup(e);
            MainWindowInstance = new Entry
            {
                Width = 805,
                Height = 500,
                WindowStartupLocation = WindowStartupLocation.CenterScreen
            };
            MainWindowInstance.Show();
        }
    }

}
