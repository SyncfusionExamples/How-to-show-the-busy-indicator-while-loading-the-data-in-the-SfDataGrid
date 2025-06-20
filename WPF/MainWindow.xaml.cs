using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace SfDataGridDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SfdataGrid.Loaded += SfdataGrid_Loaded;
            SfdataGrid.ItemsSourceChanged += SfdataGrid_ItemsSourceChanged;
        }

        async void SfdataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.SfdataGrid.ItemsSource = await (this.DataContext as ViewModel).GetRecords();
        }

        void SfdataGrid_ItemsSourceChanged(object sender, GridItemsSourceChangedEventArgs e)
        {
            sfBusyIndicator.IsBusy = false;
        }
    }
}
