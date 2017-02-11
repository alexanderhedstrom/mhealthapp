using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This interface exists to ensure that the per platform methods for exiting the application are implemented. 
 * Exiting the application in Android is not the same and exiting it in IOS. 
 * 
 * This class makes ues of the dependency service. More info here: https://developer.xamarin.com/guides/xamarin-forms/dependency-service/introduction/
 */


namespace CAPLab
{
    public interface ICloseApplication
    {
        void CloseApp();
    }
}
