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

namespace Ex07
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        Loja loja;
        VeiculoWindow window = new VeiculoWindow();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnLoja_Click(object sender, RoutedEventArgs e)
        {
            loja = new Loja(txtNome.Text);
            window.Show();
        }

        private void BtnInserir_Click(object sender, RoutedEventArgs e)
        {
            string p = window.txtPlaca.Text;
            string f = window.txtFabricante.Text;
            string m = window.txtModelo.Text;
            int a = int.Parse(window.txtAno.Text);
            decimal pr = decimal.Parse(window.txtPreco.Text);
            Veiculo v = new Veiculo(p, f, m, a, pr);
            loja.Inserir(v);
        }

        private void BtnFabricante_Click(object sender, RoutedEventArgs e)
        {
            listVeiculo.ItemsSource = loja.ListarPorFabricante();
        }
    }
}
