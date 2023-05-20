﻿using System;
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
using System.IO;
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
            AjouterNom.Text = "Nom animé";
            
            AjouterImage.Visibility = Visibility.Visible;
            AjouterImage.Text = "Image";
            Note.Visibility = Visibility.Visible;
            Note.Text = "Note/20";
            Bool.Visibility = Visibility.Visible;
            Bool.Text = "en cours (true or false)";
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
            Appliquer.Visibility = Visibility.Collapsed;

            NomEcri.Visibility = Visibility.Collapsed;
            PrenomEcri.Visibility = Visibility.Collapsed;
            AgeEcri.Visibility = Visibility.Collapsed;

            AjouterNom.Visibility = Visibility.Visible;
            AjouterNom.Text = myData.CurrentAnime.NomAnime;

            AjouterImage.Visibility = Visibility.Visible;
            AjouterImage.Text = myData.CurrentAnime.Image;

            
            Note.Visibility = Visibility.Visible;
            Note.Text = myData.CurrentAnime.Cote.ToString();

            Bool.Visibility = Visibility.Visible;
            Bool.Text = myData.CurrentAnime.EnCours.ToString();

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
                Appliquer.Visibility = Visibility.Collapsed;

                MenuGenre.IsChecked = false;
                AjouterNom.Visibility = Visibility.Collapsed;
                
                AjouterImage.Visibility = Visibility.Collapsed;
                Note.Visibility = Visibility.Collapsed;
                Bool.Visibility = Visibility.Collapsed;
                ecrivain.Visibility = Visibility.Collapsed;
                genre.Visibility = Visibility.Collapsed;
                comboecri.Visibility = Visibility.Collapsed;
                combogenre.Visibility = Visibility.Collapsed;

                AppliquerEcri.Visibility = Visibility.Visible;
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
           
            int note,v;
            
            bool b;
            Ecrivain e1;
            Genre g1;
            
            note = Int32.Parse(Note.Text);
            b = bool.Parse(Bool.Text);
            v = ecrivain.SelectedIndex;
            e1 = myData.ListEcrivain[v];
            v=genre.SelectedIndex;
            g1 = myData.ListGenre[v];

            Anime anim = new Anime(AjouterNom.Text, DateTime.Now , AjouterImage.Text, note, b,e1, g1);
            myData.ListAnime.Add(anim);
            //DataContext = null;
            //Serializers.SerializeBin(myData, "test.bin");
            //DataContext = myData;
        }

        private void EcrivainSave(object sender, RoutedEventArgs e)
        {
            //aller récup les infos

            //string nom, prenom;
            int age;
            age = Int32.Parse(AgeEcri.Text);
            Ecrivain E1= new Ecrivain(NomEcri.Text,PrenomEcri.Text,age);
            myData.ListEcrivain.Add(E1);

            //DataContext = null;
            //Serializers.SerializeBin(myData, "test.bin");
            //DataContext = myData;
        }

        private void Supprimer_Click(object sender, RoutedEventArgs e)
        {
            myData.ListAnime.Remove(myData.CurrentAnime);
        }

        private void ModifierSave_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
