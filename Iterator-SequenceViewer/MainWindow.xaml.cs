using System.Windows;
using Iterator_SequenceLibrary;

namespace Iterator_SequenceViewer
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
            var sequence = new FibonacciSequence(10);
            foreach (var item in sequence)
                OutputListBox.Items.Add(item);
        }
    }
}
