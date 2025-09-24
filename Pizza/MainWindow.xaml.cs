using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Pizza
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<string> teszta = new List<string> { "vékony", "normál", "extra vastag" };
        List<string> meret = new List<string> { "kicsi", "közepes", "nagy" };
        public MainWindow()
        {
            InitializeComponent();
            lb_teszta.ItemsSource = teszta;
            cmb_meret.ItemsSource = meret;
        }
        //# FF6D6D6D
        private void btn_ossz_Click(object sender, RoutedEventArgs e)
        {
            lbl_ossz.Content = "Rendelés összegzése: ";
			var teszta = lb_teszta.SelectedItem;
            var meret = cmb_meret.SelectedItem;
            string feltetek = "";
            string atvetel = "";
            
           
			if (chb_sajt.IsChecked == true)
            {
                feltetek += "\n\tsajt";
            }
            if (chb_sonka.IsChecked == true)
            {
                feltetek += "\n\tsonka";
            }
            if (chb_gomba.IsChecked == true)
            {
                feltetek += "\n\tgomba";
            }
            if (chb_kukorica.IsChecked == true)
            {
                feltetek += "\n\tkukorica";
            }
            if (chb_oliva.IsChecked == true)
            {
                feltetek += "\n\tolívabogyó";
            }
            if (string.IsNullOrEmpty(feltetek))
            {
                feltetek = "nincs feltét";
			}
			if (rb_haz.IsChecked == true)
            {
                atvetel += " házhoz szállítás";
            }
            else if (rb_szem.IsChecked == true)
            {
                atvetel += "Személyes átvétel";
            }

            if (lb_teszta.SelectedIndex == -1 || cmb_meret.SelectedIndex == -1|| atvetel == "")
            {
                MessageBox.Show(this,"Kötelező a tészta, méret és az átvétel kiválasztása!", "Nincs kiválasztott Elem!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
			}

            txt_ossz.Text = $"Tészta: {teszta}\nMéret: {meret}\nFeltétek: {feltetek}\nÁtvétel: {atvetel}";
		}
    }
}