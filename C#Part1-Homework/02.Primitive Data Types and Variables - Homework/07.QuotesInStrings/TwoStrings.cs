﻿namespace QuotesInStrings
{
    using System;

    class TwoStrings
    {
        /* Declare two string variables and assign them with following value:
           The "use" of quotations causes difficulties.
           Do the above in two different ways - with and without using quoted strings.
           Print the variables to ensure that their value was correctly defined.
         */

        static void Main()
        {
            string quoted = @"The ""use"" of quotations causes difficulties.";
            string escaped = "The \"use\" of quotations causes difficulties.";
            Console.WriteLine(quoted);
            Console.WriteLine(escaped);
        }
    }
}
