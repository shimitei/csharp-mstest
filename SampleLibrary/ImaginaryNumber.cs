using System;

namespace TDDBC8th
{
    public class ImaginaryNumber : AbstractImaginaryNumber
    {
        private PurelyImaginaryNumber purelyImaginaryNumber;

        public ImaginaryNumber(int realPart, int imaginaryPart) : base(realPart, imaginaryPart)
        {
            this.purelyImaginaryNumber = new PurelyImaginaryNumber(imaginaryPart);
        }

        public ImaginaryNumber GetConjugate()
        {
            return new ImaginaryNumber(this.realPart, -this.imaginaryPart);
        }
    }
}
