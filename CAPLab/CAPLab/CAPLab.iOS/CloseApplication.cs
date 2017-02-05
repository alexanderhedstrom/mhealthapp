using System;
using System.Collections.Generic;
using System.Text;
using CAPLab;
[assembly: Xamarin.Forms.Dependency(typeof(ICloseApplication))]

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
