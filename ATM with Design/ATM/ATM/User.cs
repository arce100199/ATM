using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class User
    {
        /* Defines a public static property named LoggedInAccountUser,
         * which can be accessed from anywhere in the code. It allows
         * you to get or set the value of the LoggedInAccountUser property
         * as a string. 
        */
        public static String LoggedInAccountUser { get; set; }

        /* defines a public static property named LoggedInAccountNumber,
         * which can be accessed from anywhere in the code. It allows
         * you to get or set the value of the LoggedInAccountNumber property
         * as a string. 
        */
        public static String LoggedInAccountNumber { get; set; }
    }
}
