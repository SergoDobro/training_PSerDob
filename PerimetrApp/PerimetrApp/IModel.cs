using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetrApp
{
    /// <summary>
    /// Protocol for developing the perimetr counting class
    /// </summary>
    interface IModel
    {
        /// <summary>
        /// Method which returns perimetr of rectangle by 2 sides
        /// </summary>
        /// <param name="a">One side of the rectangle</param>
        /// <param name="b">Other side of the rectangle</param>
        /// <returns></returns>
        int GetP(int a, int b);
    }
}
