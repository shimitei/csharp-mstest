using System;
using TDDBC8th.Test;

namespace SampleLibrary
{
    public class ImaginaryNumber
    {
        public readonly int realPart;
        private PurelyImaginaryNumber purelyImaginaryNumber;
        public int imaginaryPart { get { return this.purelyImaginaryNumber.imaginaryPart; } }

        public ImaginaryNumber(int realPart, int imaginaryPart)
        {
            if (realPart == 0)
            {
                throw new ArgumentException("実部に0は指定できません");
            }
            this.realPart = realPart;
            this.purelyImaginaryNumber = new PurelyImaginaryNumber(imaginaryPart);
        }

        public ImaginaryNumber GetConjugate()
        {
            return new ImaginaryNumber(this.realPart, -this.imaginaryPart);
        }

        public override string ToString()
        {
            var imaginaryPartSign = (this.imaginaryPart < 0)? "-" : "+";
            var absImaginaryPartNumber = Math.Abs(this.imaginaryPart);
            var imaginaryPartStr = (absImaginaryPartNumber == 1) ? "" : absImaginaryPartNumber.ToString();
            return $"{this.realPart} {imaginaryPartSign} {imaginaryPartStr}i";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            ImaginaryNumber c = (ImaginaryNumber)obj;
            return (this.realPart == c.realPart) && (this.imaginaryPart == c.imaginaryPart);
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + this.realPart.GetHashCode();
            hash = hash * 23 + this.imaginaryPart.GetHashCode();
            return hash;
        }
    }
}
