using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace WpfApp5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            int age = int.Parse(txtAge.Text);
            //bool gender = rdbMale.IsChecked == true;
           
            lblName.Content = name;
            lblAge.Content = age;
            //lblGender.Content = gender ? "Male" : "Female";
            
            string s = cbxGender.SelectedValue?.ToString()??"null";
            lblGender.Content = cbxGender.SelectedItem;
        }

        string[] arr = new string[] { "male", "female" };
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbxGender.ItemsSource = arr;
            cbxGender.SelectedValue = arr[0];
           
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
