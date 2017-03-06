// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace SlavikDev.Rush.Iterators
{
    /// <summary>
    /// The times iterator for integers.
    /// </summary>
    public static class TimesIterator
    {
        #region Delegates
        
        /// <summary>
        /// The delegate representing Times iterator's body.
        /// </summary>
        public delegate void TimesIteratorBody();

        /// <summary>
        /// The delegate representing Times iterator with index body.
        /// </summary>
        /// <param name="index">The iteration index.</param>
        public delegate void TimesIteratorWithIndexBody( int index );

        #endregion
        
        #region Extended Behavior

        /// <summary>
        /// Runs the specified body the number of times, similar to Ruby:
        ///     5.times { puts "Hello" }
        /// </summary>
        /// <example>
        ///     5.Times( () => { Console.WriteLine( "Hello" ); } );
        /// </example>
        /// <param name="number_of_iterations">The number of iterations to run.</param>
        /// <param name="body">The iterator's body.</param>
        public static void Times( 
            this int number_of_iterations, 
            TimesIteratorBody body 
        )
        {
            for ( var index = 0; index < number_of_iterations; ++index )
            {
                body();
            }
        }

        /// <summary>
        /// Runs the specified body the number of times, 
        /// supplying index variable to the body.
        /// Similar to Ruby:
        ///     5.times { |i| puts "Hello #{i}" }
        /// </summary>
        /// <example>
        ///     5.Times( i => { Console.WriteLine( "Hello, {0}", i ); } );
        /// </example>
        /// <param name="number_of_iterations">The number of iterations to run.</param>
        /// <param name="body">The iterator's body.</param>
        public static void Times( 
            this int number_of_iterations, 
            TimesIteratorWithIndexBody body 
        )
        {
            for ( var index = 0; index < number_of_iterations; ++index )
            {
                body( index );
            }
        }

        #endregion
    }
}