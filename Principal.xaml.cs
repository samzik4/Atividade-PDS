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

namespace atv1_AGORA_VAI
{
    /// <summary>
    /// Lógica interna para Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btt_soma_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text = (float.Parse(txt_val1.Text) + float.Parse(txt_val2.Text)).ToString();
            txt_val1.Clear(); txt_val2.Clear();
        }

        private void btt_sub_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text = (float.Parse(txt_val1.Text) - float.Parse(txt_val2.Text)).ToString();
            txt_val1.Clear(); txt_val2.Clear();
        }

        private void btt_multi_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text = (float.Parse(txt_val1.Text) * float.Parse(txt_val2.Text)).ToString();
            txt_val1.Clear(); txt_val2.Clear();
        }

        private void btt_div_Click(object sender, RoutedEventArgs e)
        {
            txt_result.Text = (float.Parse(txt_val1.Text) / float.Parse(txt_val2.Text)).ToString();
            txt_val1.Clear(); txt_val2.Clear();
        }

        private void btt_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
