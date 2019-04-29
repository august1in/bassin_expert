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
   
        
    }
    public void ouvrirGpio()
    {
        pin = gpioController.OpenPin();
        pin.SetDriveMode(GpioPinDriveMode.Output);
        pin.Write(GpioPinValue.Low);

        Thread.Sleep(3000);
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

    public Class1()
	{
	}
}
