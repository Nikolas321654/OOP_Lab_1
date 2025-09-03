using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laboratory
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Clean_Click(object sender, RoutedEventArgs e)
        {
            ContentTextBlock.Text = "";
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (WorkComboBox.SelectedItem is ComboBoxItem selectedItem)
            {
                string ?selectedValue = selectedItem.Content.ToString();
                if (string.IsNullOrEmpty(selectedValue)) return;
                
                if (string.IsNullOrEmpty(selectedValue))
                    return;

                    switch (selectedValue)
                {
                    case "Work-1":
                        WorkOne workOne = new WorkOne();
                        workOne.Show();
                        break;
                    case "Work-2":
                        WorkTwo workTwo = new WorkTwo();
                        workTwo.Show();
                        break;
                }
            }
        }

        public void AddText(string message)
        {
            ContentTextBlock.Text += $" {message}";
        }
    }
}