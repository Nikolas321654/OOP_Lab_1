using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Laboratory.Dialog_Windows
{
    public interface IServices
    {
        void GetValue(FrameworkElement textElement);
    }

    internal class Services: IServices
    {
        public void GetValue(FrameworkElement textElement)
        {
            MainWindow ?mainWindow = Application.Current.MainWindow as MainWindow;
            if (mainWindow == null) return;

            if (mainWindow != null)
            {
                if (textElement is TextBlock textBlock)
                {
                    string message = textBlock.Text;
                    mainWindow.AddText(message);
                }
                else if (textElement is TextBox texBox)
                {
                    string message = texBox.Text;
                    mainWindow.AddText(message);
                }
            }
        }
    }
}
