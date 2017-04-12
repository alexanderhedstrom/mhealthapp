using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using System.ComponentModel;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using CAPLab;
using CAPLab.Droid;
using Android.Hardware;
using Xamarin.Forms;

using Android.Support.V4.App;



[assembly: Dependency(typeof(IStepCounter))]

namespace CAPLab.Droid
{
    [Service(Enabled = true)]
    class StepService : ISensorEventListener, IStepCounter
    {

        

        public int steps;

        public IntPtr Handle => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnAccuracyChanged(Sensor sensor, [GeneratedEnum] SensorStatus accuracy)
        {
            throw new NotImplementedException();
        }

        public void OnSensorChanged(SensorEvent e)
        {
            steps += (int)e.Values[0];
        }

        void RegisterListeners()
        {
            var sensorManager = (SensorManager)Forms.Context.GetSystemService(Context.SensorService);
            var sensor = sensorManager.GetDefaultSensor(SensorType.StepCounter);
            sensorManager.RegisterListener(this, sensor, SensorDelay.Normal);          
        }

        public int getSteps()
        {
            //RegisterListeners causes the app to error out. 
            //Throws and invalid cast exception. Usually at line 56.
            //RegisterListeners();
            return steps;
        }



    }
}