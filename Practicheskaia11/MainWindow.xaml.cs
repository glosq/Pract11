using System.Text.RegularExpressions;
using System.Windows;

namespace Practicheskaia11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string s = "aa afa aba abba abbba abca abea";
        private void btRegex(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"aa|aba|abba|abbba");
            Match match = regex.Match(s);
            if (match.Value != "")
            {
                MatchCollection matches = regex.Matches(s);
                if (matches.Count > 0)
                {
                    object[] mas = new object[matches.Count];
                    matches.CopyTo(mas, 0);
                    listBox.ItemsSource = mas;
                }
            }
        }

        private void btFound(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex(@"(a[a-f]a)");
            Match match = regex.Match(s);
            if (match.Value != "")
            {
                MatchCollection matches = regex.Matches(s);
                if (matches.Count > 0)
                {
                    object[] mas = new object[matches.Count];
                    matches.CopyTo(mas, 0);
                    listBox.ItemsSource = mas;
                }
            }
        }

        private void btInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сюда туда");
        }

        private void btExit(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
