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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TwitchBot.Pages
{
    /// <summary>
    /// Interaction logic for Message.xaml
    /// </summary>
    public partial class Message : UserControl
    {
        public Message(string MessageName = "Add command", string Name = "", string command = "")
        {
            InitializeComponent();
            Caption.Content = MessageName;
            CommandText.Text = Name;
            CMD.Text  = command;

        }

        private void DoubleAnimationUsingKeyFrames_Completed(object sender, EventArgs e)
        {
           MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
           mainWindow.WorkingArea.Children.Remove(this);
        }

        private void Accept_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = (MainWindow)Application.Current.MainWindow;
            if(CMD.Text.Length > 0 && CommandText.Text.Length > 0)
            {
                foreach(var item in mainWindow.commands)
                {
                    if(item.Cmd == CMD.Text)
                    {
                        MessageBox.Show("The command with this text, has already been added.", "TwitchBot");
                        return;
                    }
                }
                Command command = new Command();
                command.Number = mainWindow.commands.Count + 1;
                command.Cmd = CMD.Text;
                command.CommandText = CommandText.Text;
                mainWindow.commands.Add(command);
                mainWindow.cmd.Add(command);
                FileManager fileManager = new FileManager();
                fileManager.WriteToFileCommands(mainWindow.commands);

                var animation = (Storyboard)FindResource("Storyboard3");
                animation.Begin();
            }
            else MessageBox.Show("Command not added. Check data.", "TwitchBot");
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
