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
using labofinal;
using CLSerializers;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyData myData = null;

        public MainWindow()
        {
            InitializeComponent();

            if (File.Exists("test.bin"))
            {
                myData = Serializers.DeserializeBin("test.bin");
                //myData.CurrentPersonne = null;
            }
            else
                myData = new MyData();

            DataContext = myData;
        }

        private void BoutonAjouter(object sender, RoutedEventArgs e)
        {
            AjouterNom.Visibility = Visibility.Visible;
            AjouterDate.Visibility = Visibility.Visible;
            AjouterImage.Visibility = Visibility.Visible;
            Note.Visibility = Visibility.Visible;
            Bool.Visibility = Visibility.Visible;
            ecrivain.Visibility = Visibility.Visible;
            genre.Visibility = Visibility.Visible;
            comboecri.Visibility = Visibility.Visible;
            combogenre.Visibility = Visibility.Visible;
            Appliquer.Visibility = Visibility.Visible;

            MenuEcrivain.IsChecked = false;
            NomEcri.Visibility = Visibility.Collapsed;
            PrenomEcri.Visibility = Visibility.Collapsed;
            AgeEcri.Visibility = Visibility.Collapsed;

            MenuGenre.IsChecked = false;
            NomGenre.Visibility = Visibility.Collapsed;
        }

        private void Modifier_Click(object sender, RoutedEventArgs e)
        {
            NomEcri.Visibility = Visibility.Collapsed;
            PrenomEcri.Visibility = Visibility.Collapsed;
            AgeEcri.Visibility = Visibility.Collapsed;

            AjouterNom.Visibility = Visibility.Visible;
            AjouterDate.Visibility = Visibility.Visible;
            AjouterImage.Visibility = Visibility.Visible;
            Note.Visibility = Visibility.Visible;
            Bool.Visibility = Visibility.Visible;
            ecrivain.Visibility = Visibility.Visible;
            genre.Visibility = Visibility.Visible;
            comboecri.Visibility = Visibility.Visible;
            combogenre.Visibility = Visibility.Visible;

            MenuEcrivain.IsChecked = false;
            NomEcri.Visibility = Visibility.Collapsed;
            PrenomEcri.Visibility = Visibility.Collapsed;
            AgeEcri.Visibility = Visibility.Collapsed;

            MenuGenre.IsChecked = false;
            NomGenre.Visibility = Visibility.Collapsed;
        }

        private void AjouterEcrivain(object sender, RoutedEventArgs e)
        {
            if (MenuEcrivain.IsChecked)
            {
                Appliquer.Visibility = Visibility.Visible;
                MenuGenre.IsChecked = false;
                AjouterNom.Visibility = Visibility.Collapsed;
                AjouterDate.Visibility = Visibility.Collapsed;
                AjouterImage.Visibility = Visibility.Collapsed;
                Note.Visibility = Visibility.Collapsed;
                Bool.Visibility = Visibility.Collapsed;
                ecrivain.Visibility = Visibility.Collapsed;
                genre.Visibility = Visibility.Collapsed;
                comboecri.Visibility = Visibility.Collapsed;
                combogenre.Visibility = Visibility.Collapsed;


                NomEcri.Visibility = Visibility.Visible;
                PrenomEcri.Visibility = Visibility.Visible;
                AgeEcri.Visibility = Visibility.Visible;

                NomGenre.Visibility = Visibility.Collapsed;

            }
            else
            {
                Appliquer.Visibility = Visibility.Collapsed;
                NomEcri.Visibility = Visibility.Collapsed;
                PrenomEcri.Visibility = Visibility.Collapsed;
                AgeEcri.Visibility = Visibility.Collapsed;
            }
        }

        private void AjouterGenre(object sender, RoutedEventArgs e)
        {
            if (MenuGenre.IsChecked)
            {
                Appliquer.Visibility = Visibility.Visible;
                MenuEcrivain.IsChecked = false;
                AjouterNom.Visibility = Visibility.Collapsed;
                AjouterDate.Visibility = Visibility.Collapsed;
                AjouterImage.Visibility = Visibility.Collapsed;
                Note.Visibility = Visibility.Collapsed;
                Bool.Visibility = Visibility.Collapsed;
                ecrivain.Visibility = Visibility.Collapsed;
                genre.Visibility = Visibility.Collapsed;
                comboecri.Visibility = Visibility.Collapsed;
                combogenre.Visibility = Visibility.Collapsed;


                NomEcri.Visibility = Visibility.Collapsed;
                PrenomEcri.Visibility = Visibility.Collapsed;
                AgeEcri.Visibility = Visibility.Collapsed;

                NomGenre.Visibility = Visibility.Visible;
            }
            else
            {
                NomGenre.Visibility = Visibility.Collapsed;
                Appliquer.Visibility = Visibility.Collapsed;

            }
        }

        private void Appliquer_Click(object sender, RoutedEventArgs e)
        {
            DataContext = null;
            Serializers.SerializeBin(myData, "test.bin");
            DataContext = myData;
        }
    }
}
