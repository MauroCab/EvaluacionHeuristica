using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class LibreriaFunciones
    {
        /// <summary>
        /// Convierte un numero a un porcentaje teniendo en cuenta
        /// el numero maximo total del cual pertenece
        /// </summary>
        /// <param name="argNumberToConvert"></param>
        /// <param name="argMaxValue"></param>
        /// <returns></returns>
        public float ConvertToPercentage(int argNumberToConvert, int argMaxValue)
        {
            return argNumberToConvert * 100 / argMaxValue;

        }
    }
}
