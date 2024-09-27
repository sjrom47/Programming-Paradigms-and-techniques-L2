using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal interface IManageVehicles
    {
        public void RegisterVehicle(string plate, string typeOfVehicle);
        public void RemoveVehicle(string plate);
    }
}
