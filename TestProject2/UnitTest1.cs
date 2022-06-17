using NUnit.Framework;
using Calculator;

namespace TestProject2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Plus_2plus2_4()
        {
            Calculators calc = new Calculators();
            double res = calc.Plus(2, 2);
            Assert.AreEqual(4,res);
        }
        [Test]
        public void Minus_4Minus2_2()
        {
            Calculators calc = new Calculators();
            double res = calc.Minus(4, 2);
            Assert.AreEqual(2, res);
        }
        [Test]
        public void Multi_2Multi2_4()
        {
            Calculators calc = new Calculators();
            double res = calc.Multi(2, 2);
            Assert.AreEqual(4, res);
        }
        [Test]
        public void Divide_10Divide2_5()
        {
            Calculators calc = new Calculators();
            double res = calc.Divide(10, 2);
            Assert.AreEqual(5, res);
        }
        [Test]
        public void Pt_2Pt2_4()
        {
            Calculators calc = new Calculators();
            double res = calc.Pt(20, 2);
            Assert.AreEqual(20, res);

        }
        [Test]
        public void Pc_2_4()
        {
            Calculators calc = new Calculators();
            double res = calc.Pc(10);
            Assert.GreaterOrEqual(res, 300);
        }
        [Test]
        public void Mass_Mass_6()
        {
            Calculators calc = new Calculators();
            double[] mass = new double[] { 1,2,3,4,5};
            double res = calc.Mass(mass);
            Assert.AreEqual(3, res);
        }
    }
}