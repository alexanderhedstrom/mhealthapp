using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * This interface exists to ensure that the per platform methods for exiting the application are implemented. 
 * Exiting the application in Android is not the same and exiting it in IOS. 
 */

namespace CAPLab
{
    public interface ICloseApplication
    {
        void CloseApp();
    }
}
