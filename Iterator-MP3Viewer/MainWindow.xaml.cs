using Iterator_MP3Library;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Input;

namespace Iterator_MP3Viewer
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            OutputListBox.Items.Clear();

            var m4as = new M4aLocator(@"C:\Users\amir\Music\iTunes\iTunes Media\Music\");
            foreach (var m4a in m4as
                .Where(m => m.Name.Contains(SearchTextBox.Text) ||
                            m.Directory.Name.Contains(SearchTextBox.Text) ||
                            m.Directory.Parent.Name.Contains(SearchTextBox.Text)))
            {
                OutputListBox.Items.Add(m4a);
            }
        }

        private void OutputListBox_MouseDoubleClick(object sender,
            MouseButtonEventArgs e)
        {
            var selectedItem = OutputListBox.SelectedItem as FileInfo;
            if (selectedItem != null)
            {
                var mediaPlayer = "wmplayer.exe";

                var processInfo = new ProcessStartInfo();
                processInfo.FileName = mediaPlayer;
                processInfo.Arguments = string.Format("\"{0}\"", selectedItem.FullName);
                Process.Start(processInfo);
            }
        }
    }
}
