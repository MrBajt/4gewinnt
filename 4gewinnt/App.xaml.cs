using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace viergewinnt
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public void AppStartup(object sender, StartupEventArgs e)
        {
            viergewinntModel Model = new viergewinntModel();
            MainViewModel ViewModel = new MainViewModel();
            MainWindow window = new MainWindow();

            Model.Tokens.Add(new Token(new Position(4,3), Color.FromRgb(40,0,60)));

            window.DataContext = ViewModel;
            ViewModel.Model = Model;
            window.Show();
        }
    }
}
