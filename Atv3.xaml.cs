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
    /// Lógica interna para Atv3.xaml
    /// </summary>
    public partial class Atv3 : Window
    {
        public Atv3()
        {
            InitializeComponent();
        }

        private void bttInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("essa tela não é funcional, sem fins lucrativos, apenas teste de grid");
        }

        private void bttSair_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
