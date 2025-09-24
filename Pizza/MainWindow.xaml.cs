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

        List<string> teszta = new List<string> { "vékony", "normál", "extra vastag"};
        List<string> meret = new List<string> { "kicsi", "közepes", "nagy" };
		public MainWindow()
        {
            InitializeComponent();
            lb_teszta.ItemsSource = teszta;
            cmb_meret.ItemsSource = meret;
		}
    }
}