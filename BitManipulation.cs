
namespace DataStructures
{
    class BitManipulation
    {
        /// <summary>
        /// Examples:
        /// 00000000000000000000000000000000 ( 0 )
        /// 11111111111111111111111111111111 (-1 )
        /// 00000000000000000000000000000000 ( 0 )
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetIntBinaryString(int number)
        {
            var binary = new char[32];
            var position = 31;
            var i = 0;

            while (i < 32)
            {
                if ((number & (1 << i)) != 0)
                {
                    binary[position] = '1';
                }
                else
                {
                    binary[position] = '0';
                }

                position--;
                i++;
            }

            return new string(binary);
        }

        public static int ZeroBit(int value, int position)
        {
            return value & ~(1 << position);
        }

        /* Example code for Main method:
         * 
         *  Console.WriteLine(DateTime.Now.Millisecond);
            Console.WriteLine();

            var value = 0;//555;
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(value), value);
            value = ~value;
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(value), value);
            value = ~value;
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(value), value);

            Console.WriteLine();
            Console.WriteLine(DateTime.Now.Millisecond);

            var dummy = Console.ReadLine();
         * 
         * 
         * --------
         *  // Get two random values.
            var rand = new Random();
            var value1 = rand.Next();
            var value2 = rand.Next();

            // Use bitwise and operator.
            var and = value1 & value2;

            // Display bits.
            Console.WriteLine(BitManipulation.GetIntBinaryString(value1));
            Console.WriteLine(BitManipulation.GetIntBinaryString(value2));
            Console.WriteLine(BitManipulation.GetIntBinaryString(and));
         * -------------
         * 
         *  const int a = 77;
            const int b = 100;
            const int c = a | b;

            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(a), a);
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(b), b);
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(c), c);
         * -----------
         * 
         *  // Demonstrate XOR for two integers.
            const int a = 5550 ^ 800;
            Console.WriteLine(BitManipulation.GetIntBinaryString(5550));
            Console.WriteLine(BitManipulation.GetIntBinaryString(800));
            Console.WriteLine(BitManipulation.GetIntBinaryString(a));
            Console.WriteLine();

            // Repeat.
            const int b = 100 ^ 33;
            Console.WriteLine(BitManipulation.GetIntBinaryString(100));
            Console.WriteLine(BitManipulation.GetIntBinaryString(33));
            Console.WriteLine(BitManipulation.GetIntBinaryString(b));
         * --------
         * 
         *  // This program takes a random integer and then shifts it right.
            // ... Then it shifts it left.
            // ... It displays the bits and also the decimal representation.
            var value1 = new Random().Next();
            for (var i = 0; i < 32; i++)
            {
                var shift = value1 >> i;
                Console.WriteLine("{0} = {1}",
                BitManipulation.GetIntBinaryString(shift), shift);
            }
            for (int i = 0; i < 32; i++)
            {
                var shift = value1 << i;
                Console.WriteLine("{0} = {1}",
                BitManipulation.GetIntBinaryString(shift), shift);
            }
         * -----------
         * 
         *  // This program uses division by powers of two and shifts.
            // ... It shows how dividing by powers of two can be done by shifting right.
            // ... The input value is determined at runtime.
            var value = int.Parse("5000");
            var value1Div = value / 2;
            var value1Shift = value >> 1;

            Console.WriteLine(value1Div);
            Console.WriteLine(value1Shift);

            int value2Div = value / 4;
            int value2Shift = value >> 2;

            Console.WriteLine(value2Div);
            Console.WriteLine(value2Shift);
         * --------------
         * 
         *  var value = 555;
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(value), value);
            value = BitManipulation. ZeroBit(value, 0);
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(value), value);
            value = BitManipulation.ZeroBit(value, 1);
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(value), value);
            value = BitManipulation.ZeroBit(value, 3);
            Console.WriteLine("{0} = {1}", BitManipulation.GetIntBinaryString(value), value);
         */
    }
}