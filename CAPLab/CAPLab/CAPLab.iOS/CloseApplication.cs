using System;
using System.Collections.Generic;
using System.Text;
using CAPLab;
[assembly: Xamarin.Forms.Dependency(typeof(ICloseApplication))]

/*
* This class makes ues of the dependency service.More info here: https://developer.xamarin.com/guides/xamarin-forms/dependency-service/introduction/
 */

namespace CAPLab.iOS
{
    public class CloseApplication : ICloseApplication
    {
        public void CloseApp()
        {
            System.Threading.Thread.CurrentThread.Abort();
        }
    }
}
