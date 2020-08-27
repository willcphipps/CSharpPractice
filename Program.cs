using System;
using System.Collections.Generic;

namespace cSharpPractice {
    class Program {

        static void reverseString (string OldString) {
            char[] stringArray = OldString.ToCharArray ();
            string reversed = String.Empty;
            for (int i = stringArray.Length - 1; i >= 0; i--) {
                reversed += stringArray[i];
            }
            Console.WriteLine (reversed);
        }
        static void StringFunction (string OldString) {

            int length = OldString.Length - 1;
            string toPrint = "";
            int i = 0;
            while (i <= length) {

                toPrint = toPrint + OldString[i];
                i += 2;
            }

            Console.WriteLine (toPrint);
        }
        static void Main (string[] args) {
            StringFunction ("this is a string function");
            reverseString ("this is also a string");
        }
    }

}