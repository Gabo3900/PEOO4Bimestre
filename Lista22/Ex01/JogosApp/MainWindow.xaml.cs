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
using Modelo;
using Negocio;

namespace JogosApp
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

        private void Button_Click_Insert(object sender, RoutedEventArgs e)
        {
            Game g = new Game();
            NGame n = new NGame();
            g.Id = 0;
            g.Nome = txtNome.Text;
            g.Fabricante = txtFab.Text;
            g.DataCompra = DateTime.Parse(txtData.Text);
            g.Estrelas = int.Parse(txtEstrela.Text);
            n.Insert(g);
            grid.ItemsSource = n.Select();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {

            Game c = new Game();
            c.Id = int.Parse(txtId.Text);
            g.Nome = txtNome.Text;
            g.Fabricante = txtFab.Text;
            g.DataCompra = DateTime.Parse(txtData.Text);
            g.Estrelas = int.Parse(txtEstrela.Text);
            NGame n = new NGame();
            n.Update(c);
            grid.ItemsSource = null;
            grid.ItemsSource = n.Select();
        }

        private void Button_Click_Top10(object sender, RoutedEventArgs e)
        {

        }
    }
}
