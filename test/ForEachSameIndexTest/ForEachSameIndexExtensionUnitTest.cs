using System;
using System.Collections.Generic;
using Xunit;
using ForEachSameIndex;

namespace ForEachSameIndexTest
{
    public class ForEachSameIndexExtensionUnitTest
    {
        // TODO: Blow out the parameter combinations for the parameter miss-match cases
        // TODO: Finish out the test cases for the larger parameter numbers

        #region 2 lists

        [Fact]
        public void TestNullParameterT2()
        {
            var t1 = new List<int> { 1, 2, 3 };
            List<int> t2 = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, (x1, x2) => actual.Add(x1 + x2)));
        }

        [Fact]
        public void TestNullCallerT2()
        {
            List<int> t1 = null;
            var t2 = new List<int> { 1, 2, 3 };
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, (x1, x2) => actual.Add(x1 + x2)));
        }

        [Fact]
        public void TestParameterMismatchT2()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 0, 0, 0, 0 };
            var actual = new List<int>();
            Assert.Throws(typeof(ArgumentException), () => t1.ForEachSameIndex(t2, (x1, x2) => actual.Add(x1 + x2)));
        }

        [Fact]
        public void TestSimpleActionT2()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var expected = new List<int> { 2, 4, 6 };
            var actual = new List<int>();
            t1.ForEachSameIndex(t2, (x1, x2) => actual.Add(x1 + x2));
            Assert.Equal(expected, actual);
        }

        #endregion 2 lists

        #region 3 lists

        [Fact]
        public void TestNullParameterT3()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, tnull, (x1, x2, x3) => actual.Add(x1 + x2 + x3)));
        }

        [Fact]
        public void TestNullCallerT3()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => tnull.ForEachSameIndex(t1, t2, (x1, x2, x3) => actual.Add(x1 + x2 + x3)));
        }

        [Fact]
        public void TestParameterMismatchT3()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 0, 0, 0, 0 };
            var t3 = new List<int> { 0, 0, 0, 0 };
            var actual = new List<int>();
            Assert.Throws(typeof(ArgumentException), () => t1.ForEachSameIndex(t2, t3, (x1, x2, x3) => actual.Add(x1 + x2 + x3)));
        }

        [Fact]
        public void TestSimpleActionT3()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var actual = new List<int>();
            var expected = new List<int> { 3, 6, 9 };
            t1.ForEachSameIndex(t2, t3, (x1, x2, x3) => actual.Add(x1 + x2 + x3));
            Assert.Equal(expected, actual);
        }

        #endregion 3 lists

        #region 4 lists

        [Fact]
        public void TestNullParameterT4()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, tnull, t3, (x1, x2, x3, x4) => actual.Add(x1 + x2 + x3 + x4)));
        }

        [Fact]
        public void TestNullCallerT4()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => tnull.ForEachSameIndex(t1, t2, t3, (x1, x2, x3, x4) => actual.Add(x1 + x2 + x3 + x4)));
        }

        [Fact]
        public void TestParameterMismatchT4()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 0, 0, 0, 0 };
            var t3 = new List<int> { 0, 0, 0, 0 };
            var t4 = new List<int> { 0, 0, 0, 0 };
            var actual = new List<int>();
            Assert.Throws(typeof(ArgumentException), () => t1.ForEachSameIndex(t2, t3, t4, (x1, x2, x3, x4) => actual.Add(x1 + x2 + x3 + x4)));
        }

        [Fact]
        public void TestSimpleActionT4()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var actual = new List<int>();
            var expected = new List<int> { 4, 8, 12 };
            t1.ForEachSameIndex(t2, t3, t4, (x1, x2, x3, x4) => actual.Add(x1 + x2 + x3 + x4));
            Assert.Equal(expected, actual);
        }

        #endregion 4 lists

        #region 5 lists

        [Fact]
        public void TestNullParameterT5()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, tnull, t3, t4, (x1, x2, x3, x4, x5) => actual.Add(x1 + x2 + x3 + x4 + x5)));
        }

        [Fact]
        public void TestNullCallerT5()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => tnull.ForEachSameIndex(t1, t2, t3, t4, (x1, x2, x3, x4, x5) => actual.Add(x1 + x2 + x3 + x4 + x5)));
        }

        [Fact]
        public void TestParameterMismatchT5()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 0, 0, 0, 0 };
            var t3 = new List<int> { 0, 0, 0, 0 };
            var t4 = new List<int> { 0, 0, 0, 0 };
            var t5 = new List<int> { 0, 0, 0, 0 };
            var actual = new List<int>();
            Assert.Throws(typeof(ArgumentException), () => t1.ForEachSameIndex(t2, t3, t4, t5, (x1, x2, x3, x4, x5) => actual.Add(x1 + x2 + x3 + x4 + x5)));
        }

        [Fact]
        public void TestSimpleActionT5()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var actual = new List<int>();
            var expected = new List<int> { 5, 10, 15 };
            t1.ForEachSameIndex(t2, t3, t4, t5, (x1, x2, x3, x4, x5) => actual.Add(x1 + x2 + x3 + x4 + x5));
            Assert.Equal(expected, actual);
        }

        #endregion 5 lists

        #region 6 lists

        [Fact]
        public void TestNullParameterT6()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, tnull, t3, t4, t5, (x1, x2, x3, x4, x5, x6) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6)));
        }

        [Fact]
        public void TestNullCallerT6()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => tnull.ForEachSameIndex(t1, t2, t3, t4, t5, (x1, x2, x3, x4, x5, x6) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6)));
        }

        [Fact]
        public void TestParameterMismatchT6()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 0, 0, 0, 0 };
            var t3 = new List<int> { 0, 0, 0, 0 };
            var t4 = new List<int> { 0, 0, 0, 0 };
            var t5 = new List<int> { 0, 0, 0, 0 };
            var t6 = new List<int> { 0, 0, 0, 0 };
            var actual = new List<int>();
            Assert.Throws(typeof(ArgumentException), () => t1.ForEachSameIndex(t2, t3, t4, t5, t6, (x1, x2, x3, x4, x5, x6) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6)));
        }

        [Fact]
        public void TestSimpleActionT6()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var t6 = new List<int> { 1, 2, 3 };
            var actual = new List<int>();
            var expected = new List<int> { 6, 12, 18 };
            t1.ForEachSameIndex(t2, t3, t4, t5, t6, (x1, x2, x3, x4, x5, x6) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6));
            Assert.Equal(expected, actual);
        }

        #endregion 6 lists

        #region 7 lists

        [Fact]
        public void TestNullParameterT7()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var t6 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, tnull, t3, t4, t5, t6, (x1, x2, x3, x4, x5, x6, x7) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7)));
        }

        [Fact]
        public void TestNullCallerT7()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var t6 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => tnull.ForEachSameIndex(t1, t2, t3, t4, t5, t6, (x1, x2, x3, x4, x5, x6, x7) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7)));
        }

        [Fact]
        public void TestParameterMismatchT7()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 0, 0, 0, 0 };
            var t3 = new List<int> { 0, 0, 0, 0 };
            var t4 = new List<int> { 0, 0, 0, 0 };
            var t5 = new List<int> { 0, 0, 0, 0 };
            var t6 = new List<int> { 0, 0, 0, 0 };
            var t7 = new List<int> { 0, 0, 0, 0 };
            var actual = new List<int>();
            Assert.Throws(typeof(ArgumentException), () => t1.ForEachSameIndex(t2, t3, t4, t5, t6, t7, (x1, x2, x3, x4, x5, x6, x7) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7)));
        }

        [Fact]
        public void TestSimpleActionT7()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var t6 = new List<int> { 1, 2, 3 };
            var t7 = new List<int> { 1, 2, 3 };
            var actual = new List<int>();
            var expected = new List<int> { 7, 14, 21 };
            t1.ForEachSameIndex(t2, t3, t4, t5, t6, t7, (x1, x2, x3, x4, x5, x6, x7) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7));
            Assert.Equal(expected, actual);
        }

        #endregion 7 lists

        #region 8 lists

        [Fact]
        public void TestNullParameterT8()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var t6 = new List<int> { 1, 2, 3 };
            var t7 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => t1.ForEachSameIndex(t2, t3, t4, t5, t6, t7, tnull, (x1, x2, x3, x4, x5, x6, x7, x8) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8)));
        }

        [Fact]
        public void TestNullCallerT8()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var t6 = new List<int> { 1, 2, 3 };
            var t7 = new List<int> { 1, 2, 3 };
            List<int> tnull = null;
            var actual = new List<int>();
            Assert.Throws(typeof(NullReferenceException), () => tnull.ForEachSameIndex(t1, t2, t3, t4, t5, t6, t7, (x1, x2, x3, x4, x5, x6, x7, x8) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8)));
        }

        [Fact]
        public void TestParameterMismatchT8()
        {
            var t1 = new List<int> { 1, 2, 3, 4 };
            var t2 = new List<int> { 0, 0, 0, 0 };
            var t3 = new List<int> { 0, 0, 0, 0 };
            var t4 = new List<int> { 0, 0, 0, 0 };
            var t5 = new List<int> { 0, 0, 0, 0 };
            var t6 = new List<int> { 0, 0, 0, 0 };
            var t7 = new List<int> { 0, 0, 0, 0 };
            var tDiffLength = new List<int> { 0, 0, 0 };
            var actual = new List<int>();
            Assert.Throws(typeof(ArgumentException), () => t1.ForEachSameIndex(t2, t3, t4, t5, t6, t7, tDiffLength, (x1, x2, x3, x4, x5, x6, x7, x8) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8)));
        }

        [Fact]
        public void TestSimpleActionT8()
        {
            var t1 = new List<int> { 1, 2, 3 };
            var t2 = new List<int> { 1, 2, 3 };
            var t3 = new List<int> { 1, 2, 3 };
            var t4 = new List<int> { 1, 2, 3 };
            var t5 = new List<int> { 1, 2, 3 };
            var t6 = new List<int> { 1, 2, 3 };
            var t7 = new List<int> { 1, 2, 3 };
            var t8 = new List<int> { 1, 2, 3 };
            var actual = new List<int>();
            var expected = new List<int> { 8, 16, 24 };
            t1.ForEachSameIndex(t2, t3, t4, t5, t6, t7, (x1, x2, x3, x4, x5, x6, x7) => actual.Add(x1 + x2 + x3 + x4 + x5 + x6 + x7));
            Assert.Equal(expected, actual);
        }

        #endregion 8 lists
    }
}