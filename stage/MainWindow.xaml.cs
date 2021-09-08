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
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace stage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           InitializeComponent();
           // InitializeComponent();

            //DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Plot pl = DataGridXaml.SelectedItem as Plot;

            MainViewModel win = new MainViewModel(pl);
            win.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Plot pl = new Plot();
            pl.haxe = haxe.Text;
            pl.vaxe = vaxe.Text;
            pl.nom = nom.Text;
            DataGridXaml.Items.Add(pl);

        }
        public PlotModel MyModel { get; private set; }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

