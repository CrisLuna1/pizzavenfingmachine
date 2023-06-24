using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaExpendedoraPizzas.StatePattern
{   /**
    * @author Jorge A. Lopez
    * @date 10/21/2022
    */
    internal interface IVendingMachineState
    {
        void DispenseProduct(String x, int cambio);
        
    }
}
