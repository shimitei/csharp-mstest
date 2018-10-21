using System;

namespace TDDBC8th
{
    public abstract class AbstractImaginaryNumber
    {
        public readonly int realPart;
        public readonly int imaginaryPart;

        public AbstractImaginaryNumber(int realPart, int imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }

        public override string ToString()
        {
            if (this.realPart == 0)
            {
                if (this.imaginaryPart == 0)
                {
                    return "0";
                }
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
            else
            {
                if (this.imaginaryPart == 0)
                {
                    return this.realPart.ToString();
                }
                var imaginaryPartSign = (this.imaginaryPart < 0) ? "-" : "+";
                var absImaginaryPartNumber = Math.Abs(this.imaginaryPart);
                var imaginaryPartStr = (absImaginaryPartNumber == 1) ? "" : absImaginaryPartNumber.ToString();
                return $"{this.realPart} {imaginaryPartSign} {imaginaryPartStr}i";
            }
        }

        public override bool Equals(object obj)
        {
            AbstractImaginaryNumber o = obj as AbstractImaginaryNumber;
            if (o != null)
            {
                return (this.realPart == o.realPart) && (this.imaginaryPart == o.imaginaryPart);
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
