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
    public partial class WorkOne : Window
    {
        private readonly IServices _service;
        public WorkOne() : this(new Services())
        {

        }

        public WorkOne(IServices services)
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
            _service.GetValue(InputTextBox);
            Close();
        }
    }
}
