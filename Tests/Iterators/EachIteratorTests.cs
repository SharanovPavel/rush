// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace Tests.Iterators
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Common;
    using NUnit.Framework;
    using SlavikDev.Rush.Iterators;

    [TestFixture]
    public sealed class EachIteratorTests
    {
        #region Tests

        [Test]
        public void TestEach()
        {
            AssertEach( "message" );
            AssertEach( "" );
            string bad = null;
            Assert.Throws<NullReferenceException>( 
                // ReSharper disable once ExpressionIsAlwaysNull
                () => bad.Each( Console.Write ) 
            );
        }

        [Test]
        public void TestEachWithIndex()
        {
            AssertEachWithIndex( "message" );
            AssertEachWithIndex( "" );
            string bad = null;
            Assert.Throws<NullReferenceException>( 
                // ReSharper disable once ExpressionIsAlwaysNull
                () => bad.Each( (ch,i) => Console.WriteLine( "{0},{1}", ch, i ) ) 
            );
        }

        #endregion

        #region Internals

        private static void AssertEach( string input )
        {
            var sb = new StringBuilder();
            input.Each( ch => sb.Append( ch ) );

            Assert.AreEqual( sb.ToString(), input );
        }

        private static void AssertEachWithIndex( string input )
        {
            var sb = new StringBuilder();
            var indexes = new List<int>();
            input.Each( (ch, i) => {
                sb.Append( ch );
                indexes.Add( i );
            });

            Assert.AreEqual( sb.ToString(), input );
            AssertIterator.IndexesGrow( 0, indexes );
        }

        #endregion
    }
}