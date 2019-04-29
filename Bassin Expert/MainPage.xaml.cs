using System;
using System.Collections.Generic;
using System.IO;
using Windows.Devices.I2c;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media;
using System.Windows;
using Windows.Devices.Enumeration;
using Windows.Devices.Spi;
using Windows.Devices.Gpio;
using System.Threading.Tasks;
using System.Threading;


// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Bassin_Expert
{

    public sealed partial class MainPage : Page
    {
        public GpioController gpioController;
        GPIO port = new GPIO();
        DispatcherTimer pHtimestamp;

        public MainPage()
        {
            this.InitializeComponent();

            port.InitGPIO();

            port.ouvrirGpio(GPIO.phPlus);
            port.ouvrirGpio(GPIO.phMoins);
            port.ouvrirGpio(GPIO.Alarme);
            port.ouvrirGpio(GPIO.eVanne);
            port.ouvrirGpio(GPIO.Nourriture);
            port.ouvrirGpio(GPIO.Chauffage);
            port.ouvrirGpio(GPIO.Bacterie);
            port.ouvrirGpio(GPIO.Pompe);
            port.ouvrirGpio(GPIO.lampeUV);
            //port.ouvrirGpio(GPIO.Bulleur);

        }

        private void Mode_auto_Click(object sender, RoutedEventArgs e)
        {

            if (port.GetMode_Auto_Etat() == false)
            {
                mode_auto.Background = new SolidColorBrush(Color.FromArgb(127, 255, 0, 0));
                mode_auto.Content = "Mode Automatique : activé";
                port.SetMode_Auto_Etat(true);
                port.allumerGpio();
            }

            else
            {
                mode_auto.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
                mode_auto.Content = "Mode Automatique : désactivé";
                port.SetMode_Auto_Etat(false);
                port.eteindreGpio();
            }
        }
    }
}