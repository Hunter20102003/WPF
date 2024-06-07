using System.Windows;

namespace WpfApp3
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
            bool gender = rdbMale.IsChecked == true;
            lblName.Content = name;
            lblAge.Content = age;
            lblGender.Content = gender ? "Male" : "Female";
        }

        string[] arr = new string[] { "male", "female" };
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cbxGender.ItemsSource = arr;
            comboBox.ItemsSource = arr; // Thiết lập ItemsSource cho comboBox
            comboBox1.ItemsSource = arr; // Thiết lập ItemsSource cho comboBox1
        }
    }
}
