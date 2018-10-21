using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDDBC8th.TestGaussianInteger
{
    [TestClass]
    public class ガウス整数の生成
    {
        [TestMethod]
        public void 実部2と虚部2を与えてガウス整数を生成できること()
        {
            var gi = new GaussianInteger(2, 2);
            Assert.AreEqual(2, gi.realPart);
            Assert.AreEqual(2, gi.imaginaryPart);
        }

        [TestMethod]
        public void 実部0虚部0のガウス整数を生成できること()
        {
            var gi = new GaussianInteger(0, 0);
            Assert.AreEqual(0, gi.realPart);
            Assert.AreEqual(0, gi.imaginaryPart);
        }
    }

    [TestClass]
    public class ガウス整数の文字列表記
    {
        [TestMethod]
        public void 実部2虚部0のガウス整数の文字列は2であること()
        {
            Assert.AreEqual("2", new GaussianInteger(2, 0).ToString());
        }

        [TestMethod]
        public void 実部0虚部0のガウス整数の文字列は0であること()
        {
            Assert.AreEqual("0", new GaussianInteger(0, 0).ToString());
        }

        [TestMethod]
        public void 実部マイナス1虚部0のガウス整数の文字列はマイナス1であること()
        {
            Assert.AreEqual("-1", new GaussianInteger(-1, 0).ToString());
        }

        [TestMethod]
        public void 実部2虚部2のガウス整数の文字列は2プラス2iであること()
        {
            Assert.AreEqual("2 + 2i", new GaussianInteger(2, 2).ToString());
        }

        [TestMethod]
        public void 実部マイナス2虚部2のガウス整数の文字列はマイナス2プラス2iであること()
        {
            Assert.AreEqual("-2 + 2i", new GaussianInteger(-2, 2).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス2のガウス整数の文字列は2ー2iであること()
        {
            Assert.AreEqual("2 - 2i", new GaussianInteger(2, -2).ToString());
        }

        [TestMethod]
        public void 実部2虚部1のガウス整数の文字列は2プラスiであること()
        {
            Assert.AreEqual("2 + i", new GaussianInteger(2, 1).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス1のガウス整数の文字列は2ーiであること()
        {
            Assert.AreEqual("2 - i", new GaussianInteger(2, -1).ToString());
        }

        [TestMethod]
        public void 実部0虚部2のガウス整数の文字列は2iであること()
        {
            Assert.AreEqual("2i", new GaussianInteger(0, 2).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス2のガウス整数の文字列はー2iであること()
        {
            Assert.AreEqual("-2i", new GaussianInteger(0, -2).ToString());
        }

        [TestMethod]
        public void 実部0虚部1のガウス整数の文字列はiであること()
        {
            Assert.AreEqual("i", new GaussianInteger(0, 1).ToString());
        }

        [TestMethod]
        public void 実部2虚部マイナス1のガウス整数の文字列はーiであること()
        {
            Assert.AreEqual("-i", new GaussianInteger(0, -1).ToString());
        }
    }

    [TestClass]
    public class 同一性の判定
    {
        [TestMethod]
        public void 実部2虚部2のガウス整数同士を比較すると同一であること()
        {
            Assert.AreEqual(new GaussianInteger(2, 2), new GaussianInteger(2, 2));
        }

        [TestMethod]
        public void 実部1虚部2と実部2虚部1のガウス整数を比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new GaussianInteger(1, 2), new GaussianInteger(2, 1));
        }

        [TestMethod]
        public void 実部2虚部2のガウス整数と整数2を比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new GaussianInteger(2, 2), 2);
        }

        [TestMethod]
        public void 実部2虚部2のガウス整数とnullを比較すると同一ではないこと()
        {
            Assert.AreNotEqual(new GaussianInteger(2, 2), null);
        }

        [TestClass]
        public class ハッシュコードの確認
        {
            [TestMethod]
            public void 実部2虚部2のガウス整数同士のハッシュコードが同一であること()
            {
                Assert.AreEqual(new GaussianInteger(2, 2).GetHashCode(),
                    new GaussianInteger(2, 2).GetHashCode());
            }
        }

        [TestMethod]
        public void 実部2虚部2のガウス整数と実部2虚部2の虚数を比較すると同一であること()
        {
            Assert.AreEqual(new ImaginaryNumber(2, 2), new GaussianInteger(2, 2));
        }

        [TestMethod]
        public void 実部0虚部2のガウス整数と実部0虚部2の虚数を比較すると同一であること()
        {
            Assert.AreEqual(new ImaginaryNumber(0, 2), new GaussianInteger(0, 2));
        }

        [TestMethod]
        public void 実部0虚部2のガウス整数と実部0虚部2の純虚数を比較すると同一であること()
        {
            Assert.AreEqual(new PurelyImaginaryNumber(2), new GaussianInteger(0, 2));
        }
    }

    [TestClass]
    public class 共役の取得
    {
        [TestMethod]
        public void 実部1虚部1のガウス整数の共役は虚部マイナス1のガウス整数であること()
        {
            Assert.AreEqual(new GaussianInteger(1, -1), new GaussianInteger(1, 1).GetConjugate());
        }

        [TestMethod]
        public void 実部1虚部マイナス1のガウス整数の共役は虚部1のガウス整数であること()
        {
            Assert.AreEqual(new GaussianInteger(1, 1), new GaussianInteger(1, -1).GetConjugate());
        }
    }
}
