using System;

namespace TDDBC8th
{
    public class PurelyImaginaryNumber : AbstractImaginaryNumber
    {
        public PurelyImaginaryNumber(int imaginaryPart) : base(0, imaginaryPart)
        {
            if (imaginaryPart == 0)
            {
                throw new ArgumentException("虚部に0は指定できません");
            }
            if (imaginaryPart == int.MinValue)
            {
                throw new ArgumentException("虚部は" + int.MinValue + "より大きい値を指定する必要があります");
            }
        }

        public PurelyImaginaryNumber GetConjugate()
        {
            return new PurelyImaginaryNumber(-this.imaginaryPart);
        }
    }
}