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

public class GPIO
{    
    public GpioPin pin;
    public GpioController gpioController;

    public static int phPlus = 5;
    public static int phMoins = 6;
    public static int Alarme = 11;
    public static int eVanne = 13;
    public static int Nourriture = 18;
    public static int Chauffage = 22;
    public static int Bacterie = 23;
    public static int Pompe = 24;
    public static int lampeUV = 25;
    //public static int Bulleur = 27;
    bool etat = false;


    public void InitGPIO()
    {       
        // GpioController gpio = GpioController.GetDefault();
        gpioController = GpioController.GetDefault();

        /* Show an error if there is no GPIO controller */
        return;
    }
    public void ouvrirGpio(int num_pin)
    {
        pin = gpioController.OpenPin(num_pin, 0);
    }

    public void allumerGpio()
    {
     //   pin = gpioController.OpenPin(num_pin, 0);
        pin.SetDriveMode(GpioPinDriveMode.Output);
        pin.Write(GpioPinValue.Low);
      //  pin = gpioController.
        //await Task.Delay(3000);
    }

    public void eteindreGpio()
    {
        //pin = gpioController.OpenPin(num_pin, 0);
        pin.SetDriveMode(GpioPinDriveMode.Output);
        pin.Write(GpioPinValue.High);
    }
    
    public string InfoGpio()
    {
        string info;

        info = pin.Read().ToString();

        return info;
    }

    private async void cdeGPIO(int duree, GpioPin pin)
    {
        pin.Write(GpioPinValue.Low);
        // Tempo duree
        await Task.Delay(TimeSpan.FromSeconds(duree));
        pin.Write(GpioPinValue.High);
    }

    public bool GetMode_Auto_Etat()
    {
        return etat;
    }

    public void SetMode_Auto_Etat(bool ETAT)
    {
        etat = ETAT;
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public GPIO()
	{
	}
}
