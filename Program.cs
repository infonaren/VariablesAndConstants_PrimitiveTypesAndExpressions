using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndConstants_PrimitiveTypesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {

            const float Pi = 3.14f;

            // C# Type is byte. .NET Type is Byte.  The number of Bytes is 1. Range is from 0 to 255.
            byte Finalnumber = 2;

            // C# Type is short. .NET Type is Int16.  The number of Bytes is 2. Range is from -32,768 to 32,767.
            short employeeId = 1;

            // C# Type is int. .NET Type is Int32.  The number of Bytes is 4. Range is from -2.1B to 2.1B.
            int countNumber = 3;

            // C# Type is long. .NET Type is Int64.  The number of Bytes is 8. Range is from -2.1B to 2.1B.
            long rollNumber = 111712205067;

            // C# Type is float. .NET Type is Single.  The number of Bytes is 4. Range is from -3.4 * 10 ^ 38 to 3.4 * 10 ^ 38.
            float radiusOfCircle = 3.14f;

            // C# Type is double. .NET Type is Double.  The number of Bytes is 8. Range is from -3.4 * 10 ^ 38 to 3.4 * 10 ^ 38.
            double circleRadius = 3.14;

            // C# Type is decimal. .NET Type is Decimal.  The number of Bytes is 16. Range is from -7.9 * 10 ^ 28 to 7.9 * 10 ^ 28.
            decimal millionDollars = 8.14m;

            // C# Type is char. .NET Type is Char.  The number of Bytes is 2. Range is Unicode Characters.
            char initialAlphabet = 'A';

            // C# Type is bool. .NET Type is Boolean.  The number of Bytes is 1. Range is True/False.
            bool isElementPresent = true;

            Console.WriteLine(Finalnumber);
            Console.WriteLine(employeeId);
            Console.WriteLine(countNumber);
            Console.WriteLine(rollNumber);
            Console.WriteLine(radiusOfCircle);
            Console.WriteLine(circleRadius);

            Console.WriteLine(millionDollars);
            Console.WriteLine(initialAlphabet);
            Console.WriteLine(isElementPresent);


            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'Z';
            var firstName = "Naren";
            var isMoving = false;

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isMoving);

            Console.WriteLine("{0} {1}",byte.MaxValue,byte.MinValue);
            Console.WriteLine(String.Format("{0} {1}", float.MaxValue, float.MinValue));
            Console.WriteLine(P);

        }
    }
}
