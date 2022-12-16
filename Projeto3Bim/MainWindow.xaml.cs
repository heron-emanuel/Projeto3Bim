using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.ComponentModel;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto3Bim
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Pais> paises = new ObservableCollection<Pais>();
        private ObservableCollection<Estado> estados = new ObservableCollection<Estado>();
        public MainWindow()
        {
            InitializeComponent();
            countryList.ItemsSource = paises;
            stateList.ItemsSource = estados;
        }

        private void On_CadastrarPais(object sender, RoutedEventArgs e)
        {
            Pais p = new Pais(countryName.Text, double.Parse(countryArea.Text));
            paises.Add(p);
        }

        private void On_InserirEstado(object sender, RoutedEventArgs e)
        {
            Estado estado = new Estado(stateName.Text, stateCode.Text, int.Parse(statePop.Text));
            try
            {
                paises[countryList.SelectedIndex].Inserir(estado);
                estados.Add(estado);
                ICollectionView view = CollectionViewSource.GetDefaultView(paises);
                view.Refresh();
            }
            catch (Exception _)
            {
                MessageBox.Show("Selecione o país para inserir o estado!");
            }
        }
        private void On_SelectedCountryChanged(object sender, SelectionChangedEventArgs e)
        {
            stateList.ItemsSource = paises[countryList.SelectedIndex].Listar();
        }
    }
}
