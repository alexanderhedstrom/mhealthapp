using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Xamarin.Forms.Dependency(typeof(CAPLab.Droid.CloseApplication))]
/*
* This class makes ues of the dependency service.More info here: https://developer.xamarin.com/guides/xamarin-forms/dependency-service/introduction/
 */

namespace CAPLab.Droid
{
    public class CloseApplication : ICloseApplication
    {
        public void CloseApp()
        {
            Android.OS.Process.KillProcess(Android.OS.Process.MyPid());
        }
    }
}