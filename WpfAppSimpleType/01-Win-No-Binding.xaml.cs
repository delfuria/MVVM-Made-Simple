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

namespace WpfAppSimpleType
{
    /// <summary>
    /// Interaction logic for _01_Win_No_Binding.xaml
    /// </summary>
    public partial class WinNoBinding : Window
    {
        public WinNoBinding()
        {
            InitializeComponent();
        }

        private void txtName_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            lblName.Content = txtName.Text;
            ChangeButtonState();
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            lboElements.Items.Add(txtName.Text);
        }

        private void ChangeButtonState()
        {
            btnAdd.IsEnabled = !string.IsNullOrEmpty(txtName.Text);
            btnRemove.IsEnabled = !string.IsNullOrEmpty(txtName.Text);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ChangeButtonState();
        }

        private void BtnRemove_OnClick(object sender, RoutedEventArgs e)
        {
            int pos = lboElements.Items.IndexOf(txtName.Text);
            if (pos >= 0)
                lboElements.Items.RemoveAt(pos);
            else
                MessageBox.Show(txtName.Text + " not found", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
