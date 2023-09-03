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
            
            FileManager file   = new FileManager();
            mainWindow.commands = file.ReadFromFileCommands();

            foreach (var i in mainWindow.commands)
            {
                mainWindow.cmd.Add(i);
            }
            membersDataGrid.ItemsSource = mainWindow.cmd;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
           Message message = new Message();
           mainWindow.WorkingArea.Children.Add(message);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var commands = mainWindow.commands;
            Message message = new Message("Edit command", mainWindow.commands[membersDataGrid.SelectedIndex].CommandText, mainWindow.commands[membersDataGrid.SelectedIndex].Cmd);

            mainWindow.WorkingArea.Children.Add(message);
        }


        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            int SelectedIndex = membersDataGrid.SelectedIndex;

            mainWindow.commands.RemoveAt(SelectedIndex);
            mainWindow.cmd.RemoveAt(SelectedIndex);

            UpdateAllIndex();

            membersDataGrid.ItemsSource = null; 
            membersDataGrid.ItemsSource = mainWindow.cmd;

            FileManager file = new FileManager();
            file.WriteToFileCommands(mainWindow.commands);
        }

        private void UpdateAllIndex()
        {
            for (int i = 1; i < mainWindow.commands.Count + 1; i++)
            {
                mainWindow.commands[i - 1].Number = i;
                mainWindow.cmd[i - 1].Number = i;
            }
        }
    }
}
