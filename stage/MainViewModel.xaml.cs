using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;

namespace stage
{
    /// <summary>
    /// Interaction logic for MainViewModel.xaml
    /// </summary>
    public partial class MainViewModel : Window
    {

        public MainViewModel( Plot pl)
        {
            InitializeComponent();
            
            this.MyModel = new PlotModel { Title = pl.nom };
            this.MyModel.Series.Add(new FunctionSeries(Math.Cos, , Double.Parse(pl.haxe), Double.Parse(pl.vaxe) 0.1));
            DataContext = this;
        }

        public PlotModel MyModel { get; private set; }
    }
    public class Plot
    {
        public string haxe { set; get; }
        public string vaxe { set; get; }
        public string nom { set; get; }
    }
}

   
