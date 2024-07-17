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
using System.Windows.Threading;

namespace CommunicationTester
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UART_Page uartPage = new UART_Page();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UART_Clicked(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new UART_Page());
        }

        public void UpdateLabel(string Text, int Number)
        {
            switch(Number)
            {
                case 0:
                    Baundrate_Lb.Content = Text;
                    break;

                case 1:
                    Com_Lb.Content = Text;
                    break;

                case 2:
                    Connection_Lb.Content = Text;
                    break;

                case 3:
                    Parity_Lb.Content = Text;
                    break;

                case 4:
                    StopBits_Lb.Content = Text;
                    break;

                case 5:
                    DataBits_Lb.Content = Text;
                    break;

                case 6:
                    Handshake_Lb.Content = Text;
                    break;

                default:
                    Baundrate_Lb.Content = "";
                    Com_Lb.Content = "";
                    Connection_Lb.Content = "";
                    Parity_Lb.Content = "";
                    StopBits_Lb.Content = "";
                    DataBits_Lb.Content = "";
                    Handshake_Lb.Content = "";

                    break;
            }
        }
    }
}