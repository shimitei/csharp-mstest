using System;

namespace TDDBC8th.Test
{
    public class PurelyImaginaryNumber
    {
        public readonly int imaginaryPart;

        public PurelyImaginaryNumber(int imaginaryPart)
        {
            if (imaginaryPart == 0)
            {
                throw new ArgumentException("虚部に0は指定できません");
            }
            if (imaginaryPart == int.MinValue)
            {
                throw new ArgumentException("虚部は" + int.MinValue + "より大きい値を指定する必要があります");
            }
            this.imaginaryPart = imaginaryPart;
        }

        public PurelyImaginaryNumber GetConjugate()
        {
            return new PurelyImaginaryNumber(-this.imaginaryPart);
        }

        public override string ToString()
        {
            if (this.imaginaryPart == 1)
            {
                return "i";
            }
            if (this.imaginaryPart == -1)
            {
                return "-i";
            }
            return this.imaginaryPart.ToString() + "i";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            PurelyImaginaryNumber c = (PurelyImaginaryNumber)obj;
            return (this.imaginaryPart == c.imaginaryPart);
        }

        public override int GetHashCode()
        {
            return this.imaginaryPart;
        }
    }
}