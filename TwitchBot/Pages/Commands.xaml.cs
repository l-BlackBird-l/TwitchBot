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

namespace TwitchBot.Pages
{
    /// <summary>
    /// Interaction logic for Commands.xaml
    /// </summary>
    public partial class Commands : UserControl
    {

        public class UserCommands
        {
            public string Number { get; set; }
            public string Command { get; set; }
        
            public string Message { get; set; }
        }

        public Commands()
        {
            InitializeComponent();

            ObservableCollection<UserCommands> members = new ObservableCollection<UserCommands>();

            members.Add(new UserCommands { Number = "1", Command = "!lox", Message = "{e.Command.ChatMessage.DisplayName} лох на {Random(0, 100)}%" });
            members.Add(new UserCommands { Number = "2", Command = "!tg", Message = "https://t.me/valg_art"});
            members.Add(new UserCommands { Number = "3", Command = "!tt", Message = "https://www.tiktok.com/@valg_art" });
            members.Add(new UserCommands { Number = "4", Command = "!vk", Message = "https://vk.com/valg_art" });
            members.Add(new UserCommands { Number = "5", Command = "!бейбик", Message = "{e.Command.ChatMessage.DisplayName} будет бейбик с {RandomNick()}" });
            members.Add(new UserCommands { Number = "6", Command = "!бзбзбз", Message = "{e.Command.ChatMessage.DisplayName} делает бзбзбз" });

            members.Add(new UserCommands { Number = "7", Command = "!lox", Message = "{e.Command.ChatMessage.DisplayName} лох на {Random(0, 100)}%" });
            members.Add(new UserCommands { Number = "8", Command = "!tg", Message = "https://t.me/valg_art" });
            members.Add(new UserCommands { Number = "9", Command = "!tt", Message = "https://www.tiktok.com/@valg_art" });
            members.Add(new UserCommands { Number = "10", Command = "!vk", Message = "https://vk.com/valg_art" });
            members.Add(new UserCommands { Number = "11", Command = "!бейбик", Message = "{e.Command.ChatMessage.DisplayName} будет бейбик с {RandomNick()}" });
            members.Add(new UserCommands { Number = "12", Command = "!бзбзбз", Message = "{e.Command.ChatMessage.DisplayName} делает бзбзбз" });




            membersDataGrid.ItemsSource = members;
        }
    }
}
