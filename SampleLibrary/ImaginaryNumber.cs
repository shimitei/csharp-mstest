using System;

namespace TDDBC8th
{
    public class ImaginaryNumber : AbstractImaginaryNumber
    {
        public ImaginaryNumber(int realPart, int imaginaryPart) : base(realPart, imaginaryPart)
        {
            if (imaginaryPart == 0)
            {
                throw new ArgumentException("虚部に0は指定できません");
            }
        }

        public ImaginaryNumber GetConjugate()
        {
            return new ImaginaryNumber(this.realPart, -this.imaginaryPart);
        }
    }
}
