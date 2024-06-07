using demoCanvas.Models;
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
using System.Windows.Shapes;

namespace demoCanvas
{
    /// <summary>
    /// Interaction logic for DemoBinding.xaml
    /// </summary>
    public partial class DemoBinding : Window
    {
        public DemoBinding()
        {
            InitializeComponent();
            dgvDisplay.ItemsSource = list;
        }
        IList<Car> list = new List<Car>()
        {
            new Car{Id = 1, Name="City", Color = "Red", Brand="Honda"},
            new Car{Id = 2, Name="Civic", Color = "Black", Brand="Honda"},
            new Car{Id = 3, Name="VF9", Color = "White", Brand="VinFast"},
        };

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string Name = txtName.Text;
            string color = txtColor.Text;
            string Brand = txtBrand.Text;
            var car = list.FirstOrDefault(x => x.Id == id);
            if (car != null) return;
            list.Add(new Car { Id = id, Name = Name, Color = color, Brand = Brand });
            dgvDisplay.ItemsSource = list;
            dgvDisplay.Items.Refresh();
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            int id=int.Parse(txtId.Text);
            var x=list.FirstOrDefault(x => x.Id == id);
            if (x == null)
            {
                return;

            }
            x.Name= txtName.Text;
            x.Color = txtColor.Text;
            x.Brand = txtBrand.Text;
            dgvDisplay.ItemsSource= list;
            dgvDisplay.Items.Refresh();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dgvDisplay_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            var c = dgvDisplay.SelectedItem as Car;
            txtId.Text=c.Id.ToString();
            txtName.Text = c.Name;
            txtColor.Text = c.Color;
            txtBrand.Text = c.Brand;

        }
    }
}
