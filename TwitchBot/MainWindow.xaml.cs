using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;

namespace TwitchBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

      public List<Command> commands = new List<Command>();
       public ObservableCollection<Command> cmd = new ObservableCollection<Command>();
        public MainWindow()
        {
            InitializeComponent();
            Auth();
        }

        void Auth()
        {
            /*
            FileManager file = new FileManager();
            BotAuth botAuth = new BotAuth();
            botAuth.ChannelName = "Valg_Art";
            botAuth.BotName = "nervo4ka";
            botAuth.Auth = "oauth:vf1j54ycd1pjevfrreq6lc3v7cooiu";
            file.WriteAuthDate(botAuth);
           
            
            FileManager file = new FileManager();
            BotAuth botAuth = new BotAuth();
            botAuth =  file.ReadAuthDate();
            MessageBox.Show(botAuth.Auth);
             */

        }

        private void Drag_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        { this.DragMove();  }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {   Application.Current.Shutdown(); }

        private void ButtonMin_Click(object sender, RoutedEventArgs e)
        {   this.WindowState = WindowState.Minimized;   }
    }
}
