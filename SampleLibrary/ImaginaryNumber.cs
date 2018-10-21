using System;
using TDDBC8th.Test;

namespace SampleLibrary
{
    public class ImaginaryNumber : object, IImaginaryNumber
    {
        public readonly int realPart;
        private PurelyImaginaryNumber purelyImaginaryNumber;
        public int imaginaryPart { get { return this.purelyImaginaryNumber.imaginaryPart; } }

        public ImaginaryNumber(int realPart, int imaginaryPart)
        {
            this.realPart = realPart;
            this.purelyImaginaryNumber = new PurelyImaginaryNumber(imaginaryPart);
        }

        public ImaginaryNumber GetConjugate()
        {
            return new ImaginaryNumber(this.realPart, -this.imaginaryPart);
        }

        public override string ToString()
        {
            if (this.realPart == 0)
            {
                return this.purelyImaginaryNumber.ToString();
            }
            var imaginaryPartSign = (this.imaginaryPart < 0)? "-" : "+";
            var absImaginaryPartNumber = Math.Abs(this.imaginaryPart);
            var imaginaryPartStr = (absImaginaryPartNumber == 1) ? "" : absImaginaryPartNumber.ToString();
            return $"{this.realPart} {imaginaryPartSign} {imaginaryPartStr}i";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is IImaginaryNumber))
            {
                return false;
            }
            // FIXME PurelyImaginaryNumberと同じような処理
            if (obj is PurelyImaginaryNumber)
            {
                if (this.realPart != 0)
                {
                    return false;
                }
                return (this.purelyImaginaryNumber.Equals(obj));
            }
            else if (obj is ImaginaryNumber)
            {
                var inum = (ImaginaryNumber)obj;
                return (this.realPart == inum.realPart) && (this.imaginaryPart == inum.imaginaryPart);
            }
            return false;
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
