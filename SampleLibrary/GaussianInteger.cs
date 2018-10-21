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

        public static GaussianInteger operator +(GaussianInteger z, GaussianInteger w)
        {
            return new GaussianInteger(z.realPart + w.realPart, z.imaginaryPart + w.imaginaryPart);
        }

        public static GaussianInteger operator -(GaussianInteger z, GaussianInteger w)
        {
            return new GaussianInteger(z.realPart - w.realPart, z.imaginaryPart - w.imaginaryPart);
        }

        public static GaussianInteger operator *(GaussianInteger z, GaussianInteger w)
        {
            return new GaussianInteger(z.realPart * w.realPart - z.imaginaryPart * w.imaginaryPart, z.realPart * w.imaginaryPart + z.imaginaryPart * w.realPart);
        }
    }
}
