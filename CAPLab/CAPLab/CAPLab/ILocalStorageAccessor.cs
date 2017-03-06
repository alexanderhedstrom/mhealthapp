using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* File name: ILocalStorageAccessor.cs
 * 
 * @description This interface exists to ensure that the per platform methods for accessing local storgae are implemented. 
 * 
 * @author Michael Miller
 * @email miller.7594@osu.edu
 * @version 02/27/2017
 * 
 */

namespace CAPLab
{
    public interface ILocalStorageAccessor
    {
        void SaveUser(User user);
        User LoadUser();

        void SaveStats(Stats stats);
        Stats LoadStats();
    }
}
