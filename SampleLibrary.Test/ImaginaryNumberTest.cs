using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDBC8th.Test;

namespace SampleLibrary.Test
{
    [TestClass]
    public class 虚数の生成
    {
        [TestMethod]
        public void 実部2と虚部2を与えて虚数を生成できること()
        {
            var inum = new ImaginaryNumber(2, 2);
            Assert.AreEqual(2, inum.realPart);
            Assert.AreEqual(2, inum.imaginaryPart);
        }

        [TestMethod]
        public void 実部0と虚部2を与えて虚数を生成できること()
        {
            var inum = new ImaginaryNumber(0, 2);
            Assert.AreEqual(0, inum.realPart);
            Assert.AreEqual(2, inum.imaginaryPart);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void 虚部0の虚数は生成できないこと()
        {
            new ImaginaryNumber(2, 0);
        }
    }

    [TestClass]
    public class 虚数の文字列表記
    {
        [TestMethod]
        public void 実部2虚部2の虚数の文字列は2プラス2iであること()
        {
            Assert.AreEqual("2 + 2i", new ImaginaryNumber(2, 2).ToString());
        }

        [TestMethod]
        public void 実部マイナス2虚部2の虚数の文字列はマイナス2プラス2iであること()
        {
            Assert.AreEqual("-2 + 2i", new ImaginaryNumber(-2, 2).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス2の虚数の文字列は2ー2iであること()
        {
            Assert.AreEqual("2 - 2i", new ImaginaryNumber(2, -2).ToString());
        }

        [TestMethod]
        public void 実部2虚部1の虚数の文字列は2プラスiであること()
        {
            Assert.AreEqual("2 + i", new ImaginaryNumber(2, 1).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス1の虚数の文字列は2ーiであること()
        {
            Assert.AreEqual("2 - i", new ImaginaryNumber(2, -1).ToString());
        }

        [TestMethod]
        public void 実部0虚部2の虚数の文字列は2iであること()
        {
            Assert.AreEqual("2i", new ImaginaryNumber(0, 2).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス2の虚数の文字列はー2iであること()
        {
            Assert.AreEqual("-2i", new ImaginaryNumber(0, -2).ToString());
        }

        [TestMethod]
        public void 実部0虚部1の虚数の文字列はiであること()
        {
            Assert.AreEqual("i", new ImaginaryNumber(0, 1).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス1の虚数の文字列はーiであること()
        {
            Assert.AreEqual("-i", new ImaginaryNumber(0, -1).ToString());
        }
    }

    [TestClass]
    public class 同一性の判定
    {
        [TestMethod]
        public void 実部2虚部2の虚数同士を比較すると同一であること()
        {
            Assert.AreEqual(new ImaginaryNumber(2, 2), new ImaginaryNumber(2, 2));
        }

        [TestMethod]
        public void 実部1虚部2と実部2虚部1の虚数を比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new ImaginaryNumber(1, 2), new ImaginaryNumber(2, 1));
        }

        [TestMethod]
        public void 実部2虚部2の虚数と整数2を比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new ImaginaryNumber(2, 2), 2);
        }

        [TestMethod]
        public void 実部2虚部2の虚数とnullを比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new ImaginaryNumber(2, 2), null);
        }

        [TestClass]
        public class ハッシュコードの確認
        {
            [TestMethod]
            public void 実部2虚部2の虚数同士のハッシュコードが同一であること()
            {
                Assert.AreEqual(new ImaginaryNumber(2, 2).GetHashCode(),
                    new ImaginaryNumber(2, 2).GetHashCode());
            }
        }

        [TestMethod]
        public void 実部0虚部2の虚数と虚部2の純虚数を比較すると同一であること()
        {
            Assert.AreEqual(new PurelyImaginaryNumber(2), new ImaginaryNumber(0, 2));
        }

        [TestMethod]
        public void 虚部2の純虚数と実部0虚部2の虚数を比較すると同一であること()
        {
            Assert.AreEqual(new ImaginaryNumber(0, 2), new PurelyImaginaryNumber(2));
        }
    }


    [TestClass]
    public class 共役の取得
    {
        [TestMethod]
        public void 実部1虚部1の虚数の共役は実部1虚部マイナス1の虚数であること()
        {
            Assert.AreEqual(new ImaginaryNumber(1, -1), new ImaginaryNumber(1, 1).GetConjugate());
        }

        [TestMethod]
        public void 虚部マイナス1の純虚数の共役は虚部1の純虚数であること()
        {
            Assert.AreEqual(new ImaginaryNumber(1, 1), new ImaginaryNumber(1, -1).GetConjugate());
        }
    }
}
