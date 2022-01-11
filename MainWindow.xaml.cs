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

namespace pasteFromClipboardLearning1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<SpecificCar> carsList = new List<SpecificCar>
            {
                new SpecificCar {Year="1989", Make="Volkswagen", Model="Passat", BodyAndTrim="Base", EngAndTranny="1.8l L4 - Gas" },
                new SpecificCar {Year="1990", Make="Mercedes", Model="C200" , BodyAndTrim="Base", EngAndTranny="1.8l L4 - Gas" },
                new SpecificCar {Year="1991", Make="Audi", Model="100" , BodyAndTrim="Base", EngAndTranny="1.8l L4 - Gas" }
            };
            carsTable.ItemsSource = carsList;
        }

        private void btnInsertFromClipboard_Click(object sender, RoutedEventArgs e)
        {
            this.txtGetData.Text = Clipboard.GetText();
            //carsTable.DataContext = Clipboard.GetText();
            carsTable.ItemsSource = Clipboard.GetText();
        }
    }
}