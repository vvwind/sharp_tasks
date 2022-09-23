namespace MTS2
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Net.Security;
    using System.Reflection.Metadata.Ecma335;

    class Program
    {
        static readonly IFormatProvider _ifp = CultureInfo.InvariantCulture;

        class Number<T,V>
        {
            readonly T _number;
            readonly V _number2;
            readonly string result;

            public Number(T number, V number2)
            {
                _number = number;

                _number2 = number2;

                result = Add(number, number2);

            }
            public static string Add<T>(T in1, V in2)

            {
               
                if ((in1.GetType() == in2.GetType()) & (in1.GetType() == typeof(double)))
                {
                    var d1 = Convert.ToDouble(in1);
                    var d2 = Convert.ToDouble(in2);
                    return (d1 + d2).ToString();
                }
                else if ((in1.GetType() == in2.GetType()) & (in1.GetType() == typeof(int)))
                {
                    var d1 = Convert.ToInt32(in1);
                    var d2 = Convert.ToInt32(in2);
                    return (d1 + d2).ToString();
                }
                else if ((in1.GetType() == in2.GetType()) & (in1.GetType() == typeof(string)))
                {
                    var d1 = Convert.ToString(in1);
                    var d2 = Convert.ToString(in2);
                    return (d1 + d2).ToString();
                }
                else if ((in1.GetType() == in2.GetType()) & (in1.GetType() == typeof(char)))
                {
                    var d1 = Convert.ToChar(in1);
                    var d2 = Convert.ToChar(in2);
                    return (d1 + d2).ToString();
                }
             
                else
                {
                    var d1 = in1.ToString();
                    var d2 = in2.ToString();
                    return (d1 + d2).ToString();
                }
            }

            public override string ToString()
            {
                return result.ToString();
            }

        }

        static void Main(string[] args)
        {
            var someValue1 = 32.5;
            var someValue2 = 62.7;

           
            var res1 = new Number<object, object> (someValue1, someValue2);

            Console.WriteLine(res1);
            Console.ReadKey();
        }
    }


}