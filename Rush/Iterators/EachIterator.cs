// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace SlavikDev.Rush.Iterators
{
    /// <summary>
    /// The each iterator for collections and strings.
    /// </summary>
    public static class EachIterator
    {
        #region Delegates
        
        /// <summary>
        /// The delegate representing Each iterator's body.
        /// </summary>
        /// <param name="character">Character returned by current iteration.</param>
        public delegate void EachCharaterBody( char character );

        /// <summary>
        /// The delegate representing Each iterator's body with index.
        /// </summary>
        /// <param name="character">Character returned by current iteration.</param>
        /// <param name="index">The iteration index.</param>
        public delegate void EachCharaterWithIndexBody( char character, int index );

        #endregion
        
        #region Extended Behavior

        /// <summary>
        /// Enumerates charaters in the specified string. Similar to Ruby's:
        ///     "message".each_with_index { |ch,i| puts "#{i} is #{ch}" }
        /// </summary>
        /// <example>
        ///     "message".Each( (ch, i) => { Console.WriteLine( "{0} is {1}", i, ch ); } );
        /// </example>
        /// <param name="enumrable_string">The string to enumerate.</param>
        /// <param name="body">The iterator's body.</param>
        public static void Each( 
            this string enumrable_string, 
            EachCharaterBody body 
        )
        {
            foreach ( var character in enumrable_string )
            {
                body( character );
            }
        }

        /// <summary>
        /// Enumerates charaters in the specified string. Similar to Ruby's:
        ///     "message".each { |ch| print ch }
        /// </summary>
        /// <example>
        ///     "message".Each( ch => { Console.Write( ch ); } );
        /// </example>
        /// <param name="enumrable_string">The string to enumerate.</param>
        /// <param name="body">The iterator's body.</param>
        public static void Each( 
            this string enumrable_string, 
            EachCharaterWithIndexBody body 
        )
        {
            var index = 0;
            foreach ( var character in enumrable_string )
            {
                body( character, index );
                ++index;
            }
        }

        #endregion
    }
}