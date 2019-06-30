using System.Collections.Generic;
using System.Windows;

namespace Facade_foreach
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickMeButton_Click(object sender, RoutedEventArgs e)
        {
            IEnumerable<Person> people = People.GetPeople();

            ManualEnumeration(people);
        }

        private void ManualEnumeration(IEnumerable<Person> people)
        {
            var enumerator = people.GetEnumerator();
            while (enumerator.MoveNext())
                PersonListBox.Items.Add(enumerator.Current);
        }

        private void ForeachEnumeration(IEnumerable<Person> people)
        {
            foreach (var person in people)
                PersonListBox.Items.Add(person);
        }
    }
}
