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

      //  internal List<Command> Commands { get => commands; set => commands = value; }

        public MainWindow()
        {
            InitializeComponent();
        }

        public void WriteToFile()
        {
            using (FileStream stream = new FileStream("Settings\\Commands.json", FileMode.Create))
            using (StreamWriter writer = new StreamWriter(stream))
            {
                Encryptor encryptor = new Encryptor();
                string json = JsonSerializer.Serialize(commands);
                writer.Write(encryptor.Encrypt(json));
            }
        }

       public List<Command> ReadFromFile()
        {
            List<Command> command = new List<Command>();
            //    RemoveEncryption("Settings\\Commands.json");
            using (FileStream stream = new FileStream("Settings\\Commands.json", FileMode.Open))
            using (StreamReader reader = new StreamReader(stream))
            {
                Encryptor encryptor = new Encryptor();
                string json = reader.ReadToEnd();
                command = JsonSerializer.Deserialize<List<Command>>(encryptor.Decrypted(json));
            }
            return command;
        }

        private void Drag_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        { this.DragMove();  }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {   Application.Current.Shutdown(); }

        private void ButtonMin_Click(object sender, RoutedEventArgs e)
        {   this.WindowState = WindowState.Minimized;   }
    }
}
