// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace SlavikDev.Rush.Loops
{
    /// <summary>
    /// The times loop extention.
    /// </summary>
    public static class TimesLoop
    {
        #region Delegates
        
        /// <summary>
        /// The delegate representing Times loop body.
        /// </summary>
        public delegate void TimesLoopBody();

        /// <summary>
        /// The delegate representing Times loop with index body.
        /// </summary>
        /// <param name="index">The iteration index.</param>
        public delegate void TimesLoopWithIndexBody( int index );

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
        /// <param name="body">The loop's body.</param>
        public static void Times( 
            this int number_of_iterations, 
            TimesLoopBody body 
        )
        {
            for ( var index = 0; index < number_of_iterations; ++index )
            {
                body();
            }
        }

        /// <summary>
        /// Runs the specified body the number of times, supplying index variable to the loop.
        /// Similar to Ruby:
        ///     5.times { |i| puts "Hello #{i}" }
        /// </summary>
        /// <example>
        ///     5.Times( i => { Console.WriteLine( "Hello, {0}", i ); } );
        /// </example>
        /// <param name="number_of_iterations">The number of iterations to run.</param>
        /// <param name="body">The loop's body.</param>
        public static void Times( 
            this int number_of_iterations, 
            TimesLoopWithIndexBody body 
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