using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace StringEncoderProject
{
    class Program
    {
        // Complete the encode function below.
        static string encode(string stringToEncode)
        {
            var encoded = string.Empty;
            var a = ReverseDigits(stringToEncode);
            var b = ReplaceVowels(a.ToLower());
            var c = ReplaceConsonants(b.ToCharArray());

            encoded = c;

            return encoded;
        }

        //Function to Reverse all digits 
        public static string ReverseDigits(string stringToReverse)
        {
            return Regex.Replace(stringToReverse,@"\d+", m => new string(m.Value.Reverse().ToArray()));
        }

        // Function to check if a character is
        // a number or not
        public static bool IsDigit(char ch)
        {
            return char.IsDigit(ch);
        }

        // Function to check if a character is
        // a special character
        public static bool IsSpecial(char ch)
        {
            return char.IsLetterOrDigit(ch) ? false : true;
        }

        // Function to check if a character is  
        // vowel or not  
        public static bool IsVowel(char ch)
        {
            if (ch != 'a' && ch != 'e' && ch != 'i'
                    && ch != 'o' && ch != 'u')
            {
                return false;
            }
            return true;
        }

        // Function that replaces consonant with  
        // next immediate consonant alphabatically  
        public static string ReplaceConsonants(char[] s)
        {

            // Start traversing the string  
            for (int i = 0; i < s.Length; i++)
            {
                //If char is y replace with a space
                if (s[i].Equals('y'))
                {
                    s[i] = ' ';
                }
                else if (s[i].Equals(' '))// If char is space replace with y
                {
                    s[i] = 'y';
                }
                else if (!IsVowel(s[i]) && !IsDigit(s[i]))//check if char is a vowel or a digit before replacing
                {
                    if (!IsSpecial(s[i]))
                    {
                        // replace the element with  
                        // previous character
                        s[i] = (char)(s[i] - 1);
                    }

                }


            }
            return String.Join("", s);
        }

        static void Main(string[] args)
        {
            var output = encode("1234567890bcdfghjklmnpqrstvwxyzaeiou");
            Console.WriteLine(output);
            Console.ReadLine();
        }

        private static string ReplaceVowels(string stringToReplace)
        {
            Dictionary<char, char> vowels = new Dictionary<char, char> { { 'a', '1' }, { 'e', '2' }, { 'i', '3' }, { 'o', '4' }, { 'u', '5' } };
            return string.Join("", stringToReplace.Select(c => vowels.ContainsKey(c) ? vowels[c] : c));
        }
    }
}
