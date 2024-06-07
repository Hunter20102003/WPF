﻿using demoCanvas.Models;
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
            dgvDisPlay.Itemsource = list;
        }
        IList<Car> list = new List<Car>()
        {
            new Car{Id=1,Name="City",Color="Red" ,Brand="Honda"}
        };

    }
}
