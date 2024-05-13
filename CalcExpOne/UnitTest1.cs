using System;
using Xunit;
using static FractionPart.Frac;
namespace CalcExpMethodOne
{
    public class UnitTest
    {
        [Fact]
        public void Test10()
        {
            
            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(10));
            if (result != 0.9090909090909091)
            {
                throw new Exception();
            }
        }
        [Fact]
        public void Test100()
        {

            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(100));
            if (result != 0.9900990099009901)
            {
                throw new Exception();
            }
        }
        [Fact]
        public void Test1000()
        {
            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(1000));
            if (result != 0.9990009990009990)
            {
                throw new Exception();
            }
        }
        public void Test10000()
        {
            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(10000));
            if (result != 0.9999000099990001)
            {
                throw new Exception();
            }
        }
        [Fact]
        public void Test100000()
        {
            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(100000));
            if (result != 0.9999900000999990)
            {
                throw new Exception();
            }
        }
        [Fact]
        public void Test1000000()
        {
            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(1000000));
            if (result != 0.9999990000010000)
            {
                throw new Exception();
            }
        }
        [Fact]
        public void Test321456()
        {
            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(321456));
            if (result != 0.9999968891640251)
            {
                throw new Exception();
            }
        }
        [Fact]
        public void Test125643()
        {
            var CalcExpOne = FractionPart.Frac.CalcExpr1;
            double result = FractionPart.Frac.DoubleValue(CalcExpOne(125643));
            if (result != 0.9999920410047436)
            {
                throw new Exception();
            }
        }
    }
}