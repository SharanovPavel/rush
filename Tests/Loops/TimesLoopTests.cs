// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace Tests.Loops
{
    using System;
    using NUnit.Framework;
    using SlavikDev.Rush.Loops;

    [TestFixture]
    public sealed class TimesLoopTests
    {
        #region Tests

        [Test]
        public void TestTimesNegative()
        {
            5.Times( () => Console.WriteLine( "Hello" ) );
            AssertSum( -10, 0 );
        }

        [Test]
        public void TestTimesPositive()
        {
            AssertSum( 5, 5 );
        }

        [Test]
        public void TestTimesZero()
        {
            AssertSum( 0, 0 );
        }

        #endregion

        #region Internals

        private static void AssertSum( int times, int expected )
        {
            var sum = 0;
            times.Times( () => ++sum );

            Assert.AreEqual( expected, sum );
        }

        #endregion
    }
}