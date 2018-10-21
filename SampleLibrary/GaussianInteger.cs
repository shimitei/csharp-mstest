using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDBC8th
{
    public class GaussianInteger : AbstractImaginaryNumber
    {
        public GaussianInteger(int realPart, int imaginaryPart) : base(realPart, imaginaryPart)
        {
        }

        public GaussianInteger GetConjugate()
        {
            return new GaussianInteger(this.realPart, -this.imaginaryPart);
        }
    }
}
