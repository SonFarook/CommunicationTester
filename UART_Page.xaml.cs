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
using System.IO.Ports;
using System.Threading;

namespace CommunicationTester
{
    /// <summary>
    /// Interaktionslogik für UART_Page.xaml
    /// </summary>
    public partial class UART_Page : Page
    {

        static SerialPort _serialPort;

        

        Parity Parity = Parity.None;
        int DataBits = 8;
        StopBits StopBits = StopBits.One;
        Handshake Handshake = Handshake.None;
        public string Baundrate { get; set; }
        public string COM { get; set; }
        string isConnected;

        public UART_Page()
        {
            InitializeComponent();
        }

        private void BR_Handler(object sender, EventArgs e)
        {
            BR_comboBox.Items.Clear();
            List<string> numbers = new List<string> { "300", "1200", "2400", "4800", "9600", "14400", "19200", "28800", "38400", "57600", "115200" };
            foreach (string number in numbers)
            {
                BR_comboBox.Items.Add(number);
            }
        }

        private void COM_Handler(object sender, EventArgs e)
        {
            COM_comboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach(string port in ports)
            {   
                if(COM_comboBox.Items.Contains(port))
                {
                    continue;
                }

                else
                {
                    COM_comboBox.Items.Add(port);
                }
            }
        }

        private void Connect_Clicked(object sender, RoutedEventArgs e)
        {    
            

            if (BR_comboBox.SelectedItem != null)
            {
                Baundrate = BR_comboBox.SelectedItem as string;
            }

            else
            {
                MessageBox.Show("Choose a Baundrate before trying to Connect");
                return;
            }
            
            if (COM_comboBox.SelectedItem!= null)
            {
                COM = COM_comboBox.SelectedItem as string;

            }
            else
            {
                MessageBox.Show("Choose a COM Port before trying to Connect");
                return;
            }

            _serialPort = new SerialPort
            {
                PortName = COM,
                BaudRate = Convert.ToInt32(Baundrate),
                Parity = Parity,
                DataBits = DataBits,
                StopBits = StopBits,
                Handshake = Handshake,
                ReadTimeout = 500,
                WriteTimeout = 500
            };


            if (!_serialPort.IsOpen)
            {
                _serialPort.Open();
                Connect_btn.Content = "Connected";
                isConnected = "Connected";

                var window = Window.GetWindow(this) as MainWindow;
                window?.UpdateLabel(Baundrate, 0);
                window?.UpdateLabel(COM, 1);
                window?.UpdateLabel(isConnected, 2);
                window?.UpdateLabel(Parity.ToString(), 3);
                window?.UpdateLabel(StopBits.ToString(), 4);
                window?.UpdateLabel(DataBits.ToString(), 5);
                window?.UpdateLabel(Handshake.ToString(), 6);
            }

            else
            {
                Connect_btn.Content = "Connect";
                isConnected = "not Connected";
                _serialPort.Close();
            }
        }

        private void Send_Btn_Clicked(object sender, RoutedEventArgs e)
        {
            Send_textBox.Clear();
            string Message = Send_textBox.Text;

            if (_serialPort.IsOpen)
            {
                _serialPort.WriteLine(Message);
                MessageBox.Show("successfully sent the message");
            }

            else
            {
                MessageBox.Show("not connected, try again");
                return;
            }
        }

        private void Get_Btn_Clicked(object sender, RoutedEventArgs e)
        {

            if (_serialPort.IsOpen)
            {
                string Message = _serialPort.ReadLine();
                Get_listBox.Items.Add(Message);
            }

            else
            {
                MessageBox.Show("not connected, try again");
                return;
            }
        }
    }
}
