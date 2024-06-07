using System.Windows;
using System.Windows.Controls;

namespace WpfApp6
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            bool gender = rdbMale.IsChecked == true;
            string g = gender ? "Male" : "Female";
            string semester = cbxSemester.SelectedValue.ToString();
            string ct = $"ID:{id},Name:{name},Gender:{g},Semester:{semester},Favorite Subject:";
            foreach (CheckBox c in splSubject.Children)
            {
                if (c.IsChecked==true) {
                    ct = ct + " " + c.Content;                       }
            }
            lblInfo.Content=ct;
           


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            cbxSemester.ItemsSource = semester;
            cbxSemester.SelectedIndex = 0;


        }
        int[] semester = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        (int, string, string, string, string)[] tuples = new[]
          {
             (1, "PRF", "CSI", "CEA", "MAE"),
             (2, "PRO", "MAD", "SSG", "OSG"),
             (3, "LAB", "JPD1", "DBI", "CSD"),
             (4, "PRJ", "JPD2", "IOT", "MAS"),
             (5, "SWP", "SWT", "SWR", "PRN1"),
             (6, "OJT", "", "", ""),
             (7, "PRN2", "EXE1", "PRU", "PRM"),
             (8, "EXE2", "MLN1", "PMG", "WDU"),
             (9, "MLN2", "SEP", "HCM", "VNR"),


        };


        private void Commonbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedSemester = (int)cbxSemester.SelectedItem; 
            splSubject.Children.Clear();
            foreach (var t in tuples)
            {
                if (selectedSemester == t.Item1) 
                {
                    if (!String.IsNullOrEmpty(t.Item2))
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Content = t.Item2;
                        checkBox.Margin = new Thickness(0, 5, 0, 5);
                        splSubject.Children.Add(checkBox);
                    }
                    if (!String.IsNullOrEmpty(t.Item3))
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Content = t.Item3;
                        checkBox.Margin = new Thickness(0, 5, 0, 5);
                        splSubject.Children.Add(checkBox);
                    }
                    if (!String.IsNullOrEmpty(t.Item4))
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Content = t.Item4; 
                        checkBox.Margin = new Thickness(0, 5, 0, 5);
                        splSubject.Children.Add(checkBox);
                    }
                    if (!String.IsNullOrEmpty(t.Item5))
                    {
                        CheckBox checkBox = new CheckBox();
                        checkBox.Content = t.Item5; 
                        checkBox.Margin = new Thickness(0, 5, 0, 5);
                        splSubject.Children.Add(checkBox);
                    }
                }
            }
        }


    }
}