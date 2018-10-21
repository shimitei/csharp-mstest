using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDBC8th.TestPurelyImaginaryNumber
{
    [TestClass]
    public class 純虚数の生成
    {
        [TestMethod]
        public void 虚部1の純虚数を生成できること()
        {
            var pin = new PurelyImaginaryNumber(1);
            Assert.AreEqual(1, pin.imaginaryPart);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void 虚部0の純虚数は生成できないこと()
        {
            new PurelyImaginaryNumber(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void 虚部INT_MINの純虚数を生成できないこと()
        {
            new PurelyImaginaryNumber(int.MinValue);
        }

        [TestMethod]
        public void 虚部INT_MINプラス1の純虚数を生成できること()
        {
            var pin = new PurelyImaginaryNumber(int.MinValue + 1);
            Assert.AreEqual(int.MinValue + 1, pin.imaginaryPart);
        }

        [TestMethod]
        public void 虚部INT_MAXの純虚数を生成できること()
        {
            var pin = new PurelyImaginaryNumber(int.MaxValue);
            Assert.AreEqual(int.MaxValue, pin.imaginaryPart);
        }
    }

    [TestClass]
    public class 純虚数の文字列表記
    {
        [TestMethod]
        public void 虚部2の純虚数の文字列は2iであること()
        {
            Assert.AreEqual("2i", new PurelyImaginaryNumber(2).ToString());
        }

        [TestMethod]
        public void 虚部マイナス2の純虚数の文字列はー2iであること()
        {
            Assert.AreEqual("-2i", new PurelyImaginaryNumber(-2).ToString());
        }

        [TestMethod]
        public void 虚部1の純虚数の文字列はiであること()
        {
            Assert.AreEqual("i", new PurelyImaginaryNumber(1).ToString());
        }

        [TestMethod]
        public void 虚部マイナス1の純虚数の文字列はーiであること()
        {
            Assert.AreEqual("-i", new PurelyImaginaryNumber(-1).ToString());
        }
    }

    [TestClass]
    public class 同一性の判定
    {
        [TestMethod]
        public void 虚部2の純虚数同士を比較すると同一であること()
        {
            Assert.AreEqual(new PurelyImaginaryNumber(2), new PurelyImaginaryNumber(2));
        }

        [TestMethod]
        public void 虚部2と虚部1の純虚数を比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new PurelyImaginaryNumber(2), new PurelyImaginaryNumber(1));
        }

        [TestMethod]
        public void 虚部2の純虚数と整数2を比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new PurelyImaginaryNumber(2), 2);
        }

        [TestMethod]
        public void 虚部2の純虚数とnullを比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new PurelyImaginaryNumber(2), null);
        }

        [TestClass]
        public class ハッシュコードの確認
        {
            [TestMethod]
            public void 虚部2の純虚数同士のハッシュコードが同一であること()
            {
                Assert.AreEqual(new PurelyImaginaryNumber(2).GetHashCode(),
                    new PurelyImaginaryNumber(2).GetHashCode());
            }
        }
    }

    [TestClass]
    public class 共役の取得
    {
        [TestMethod]
        public void 虚部1の純虚数の共役は虚部マイナス1の純虚数であること()
        {
            Assert.AreEqual(new PurelyImaginaryNumber(-1), new PurelyImaginaryNumber(1).GetConjugate());
        }

        [TestMethod]
        public void 虚部マイナス1の純虚数の共役は虚部1の純虚数であること()
        {
            Assert.AreEqual(new PurelyImaginaryNumber(1), new PurelyImaginaryNumber(-1).GetConjugate());
        }


        [TestMethod]
        public void 虚部2147483647の純虚数の共役は虚部マイナス2147483647の純虚数であること()
        {
            Assert.AreEqual(new PurelyImaginaryNumber(-2147483647), new PurelyImaginaryNumber(2147483647).GetConjugate());
        }

        [TestMethod]
        public void 虚部マイナス2147483647の純虚数の共役は虚部2147483647の純虚数であること()
        {
            Assert.AreEqual(new PurelyImaginaryNumber(2147483647), new PurelyImaginaryNumber(-2147483647).GetConjugate());
        }
    }
}
