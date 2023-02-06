using System.IO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using static TwitchBot.MainWindow;
using System.Text.Json;

namespace TwitchBot.Pages
{
    /// <summary>
    /// Interaction logic for Commands.xaml
    /// </summary>
    public partial class Commands : UserControl
    {
        MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;




        public Commands()
        {
            InitializeComponent();
            /*
            List<Command> com1 = new List<Command>();
            Command command = new Command();
            command.Number = 0;
            command.Cmd = "!lox";
            command.CommandText = "Лох на 100%";
            com1.Add(command);

            Command command1 = new Command();
            command1.Number = 1;
            command1.Cmd = "!tt";
            command1.CommandText = "Подписывайтесь на тт";
            com1.Add(command1);

            WriteToFile(com1);
            */
            

            mainWindow.commands = mainWindow.ReadFromFile();
            ObservableCollection<Command> cmd = new ObservableCollection<Command>();
            
            foreach(var i in mainWindow.commands)
            {
                cmd.Add(i);
            }
            membersDataGrid.ItemsSource = cmd;
            
            /*
            ObservableCollection<Command> members = new ObservableCollection<Command>();


            members.Add(new Command { Number = 1, Cmd = "!lox", CommandText = "{e.Command.ChatMessage.DisplayName} лох на {Random(0, 100)}%" });
            members.Add(new Command { Number = 2, Cmd = "!tg", CommandText = "https://t.me/valg_art"});
            members.Add(new Command { Number = 3, Cmd = "!tt", CommandText = "https://www.tiktok.com/@valg_art" });
            members.Add(new Command { Number = 4, Cmd = "!vk", CommandText = "https://vk.com/valg_art" });
            members.Add(new Command { Number = 5, Cmd = "!бейбик", CommandText = "{e.Command.ChatMessage.DisplayName} будет бейбик с {RandomNick()}" });
            members.Add(new Command { Number = 6, Cmd = "!бзбзбз", CommandText = "{e.Command.ChatMessage.DisplayName} делает бзбзбз" });


            membersDataGrid.ItemsSource = members;
            */
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
           Message message = new Message();
            mainWindow.WorkingArea.Children.Add(message);

        }
    }
}
