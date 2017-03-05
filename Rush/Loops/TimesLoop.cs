// Copyright (C) 2017 Viacheslav Shynkarenko.
// All Rights Reserved.

namespace SlavikDev.Rush.Loops
{
    /// <summary>
    /// The times loop extention.
    /// </summary>
    public static class TimesLoop
    {
        #region Extended Behavior

        /// <summary>
        /// The delegate representing Times loop body.
        /// </summary>
        public delegate void TimesLoopBody();

        /// <summary>
        /// Runs the specified body the number of times, similar to Ruby:
        ///     5.times { puts "Hello" }
        /// </summary>
        /// <example>
        ///     5.Times( () => { Console.WriteLine( "Hello" ); } );
        /// </example>
        /// <param name="number_of_iterations">The number of iterations to run.</param>
        /// <param name="body">The loop's body.</param>
        public static void Times( this int number_of_iterations, TimesLoopBody body )
        {
            for ( var index = 0; index < number_of_iterations; ++index )
            {
                body();
            }
        }

        #endregion
    }
}