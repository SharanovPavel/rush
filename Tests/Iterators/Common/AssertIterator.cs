// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace Tests.Iterators.Common
{
    using System.Collections.Generic;
    using NUnit.Framework;

    public static class AssertIterator
    {
        #region Extended Behavior

        public static void IndexesGrow( int from, IEnumerable<int> indexes )
        {
            var expected_index = from;
            foreach ( var index in indexes )
            {
                Assert.AreEqual( expected_index, index );
                ++expected_index;
            }
        }

        #endregion
    }
}