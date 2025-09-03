using Laboratory.Dialog_Windows;
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

namespace Laboratory
{
    public partial class WorkTwo : Window
    {
        private readonly IServices _service;
        public WorkTwo() : this(new Services())
        {

        }

        public WorkTwo(IServices services)
        {
            InitializeComponent();
            _service = services;
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            _service.GetValue(TextBlockSlider);
            Close();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            TextBlockSlider.Text = Math.Round(e.NewValue).ToString();
        }
    }
}
