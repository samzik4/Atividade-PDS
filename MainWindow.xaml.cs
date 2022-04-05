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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace atv1_AGORA_VAI
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btt_exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            txt_cadastro.Clear(); txt_senha.Clear();
        }

        private void btt_log_Click(object sender, RoutedEventArgs e)
        {
            string cadastro = txt_cadastro.Text;
            string senha = txt_senha.ToString();
            Principal telaCall = new Principal();
            if ((cadastro != "") && (senha != ""))
            {
                MessageBox.Show("seja bem vind@ " + cadastro);
                    telaCall.ShowDialog();
                    
            }
            else
                MessageBox.Show("insira um usuário e senha");
            txt_cadastro.Clear();
            txt_senha.Clear();
        }

        private void txt_inf_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Insira um usuário e senha para acessar a calculadora");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Atv3 atv3 = new Atv3();
            atv3.ShowDialog();
        }
    }
}
