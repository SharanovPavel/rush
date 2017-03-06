// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace Tests.Iterators
{
    using System.Collections.Generic;
    using Common;
    using NUnit.Framework;
    using SlavikDev.Rush.Iterators;

    [TestFixture]
    public sealed class TimesIteratorTests
    {
        #region Tests

        [Test]
        public void TestTimesNegative()
        {
            AssertSum( -10, 0 );
            AssertSumWithIndex( -10, 0 );
        }

        [Test]
        public void TestTimesPositive()
        {
            AssertSum( 5, 5 );
            AssertSumWithIndex( 5, 5 );
        }

        [Test]
        public void TestTimesZero()
        {
            AssertSum( 0, 0 );
            AssertSumWithIndex( 0, 0 );
        }

        #endregion

        #region Internals

        private static void AssertSum( int times, int expected )
        {
            var sum = 0;
            times.Times( () => ++sum );

            Assert.AreEqual( expected, sum );
        }

        private static void AssertSumWithIndex( int times, int expected )
        {
            var sum = 0;
            var indexes = new List<int>();
            times.Times( index => { ++sum; indexes.Add( index ); } );

            Assert.AreEqual( expected, sum );
            Assert.AreEqual( times < 0 ? 0 : times, indexes.Count );
            AssertIterator.IndexesGrow( 0, indexes );
        }

        #endregion
    }
}