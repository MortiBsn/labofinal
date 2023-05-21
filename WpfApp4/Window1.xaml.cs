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
using System.Windows.Shapes;



namespace WpfApp4
{
    /// <summary>
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    
    public partial class Window1 : Window
    {
        int val;
        public Window1()
        {
            InitializeComponent();
        }

        private void changer(object sender, SelectionChangedEventArgs e)
        {
            if (ajouter.SelectedIndex == 0)
            {
                //rouge
                test.Background = new SolidColorBrush(Colors.Red);
            }
            if (ajouter.SelectedIndex == 1)
            {
                //vert
                test.Background = new SolidColorBrush(Colors.Green);
            }
            if (ajouter.SelectedIndex == 2)
            {
                //bleu
                test.Background = new SolidColorBrush(Colors.Blue);
            }
            if (ajouter.SelectedIndex == 3)
            {
                //Jaune
                test.Background = new SolidColorBrush(Colors.Yellow);
            }
        }
        public event EventHandler<OptionEventArgs> OptionChanged;

        private void Changer_click(object sender, RoutedEventArgs e)
        {
            //changer et eteindre la fenetre
            Appliquer(sender, e);
            Cancel_Click(sender, e);
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Appliquer(object sender, RoutedEventArgs e)
        {
            int txt;
            txt = int.Parse(police.Text);

            if (ajouter.SelectedIndex == 0)
            {
                //rouge
                test.Background = new SolidColorBrush(Colors.Red);
                var options = new OptionEventArgs((Colors.Red), txt);
                OptionChanged?.Invoke(this, options);
            }
            if (ajouter.SelectedIndex == 1)
            {
                //vert
                test.Background = new SolidColorBrush(Colors.Green);
                var options = new OptionEventArgs((Colors.Green), txt);
                OptionChanged?.Invoke(this, options);
            }
            if (ajouter.SelectedIndex == 2)
            {
                //bleu
                test.Background = new SolidColorBrush(Colors.Blue);
                var options = new OptionEventArgs((Colors.Blue), txt);
                OptionChanged?.Invoke(this, options);
            }
            if (ajouter.SelectedIndex == 3)
            {
                //Jaune
                test.Background = new SolidColorBrush(Colors.Yellow);
                var options = new OptionEventArgs((Colors.Yellow), txt);
                OptionChanged?.Invoke(this, options);
            }



        }
    }


}
