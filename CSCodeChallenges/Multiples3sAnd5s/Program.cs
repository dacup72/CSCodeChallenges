namespace Multiples3sAnd5s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code Challenge 1");
            // Find the sum of all multiples of 3 or 5 below 1000 and print it out to the console.

            //int total = 0;

            //for (int i = 1; i < 1000; i++)
            //{
            //    if (i % 3 == 0 || i % 5 == 0)
            //        total += i;
            //}

            //Console.WriteLine(total);

            //int total = 0;

            //for (int i = 1; i < 1000; i++)
            //{
            //    if ((i - 3 * (i / 3)) == 0 || ((i - 5 * (i / 5)) == 0))
            //        total += i;
            //}

            //Console.WriteLine(total);

            int total = 0;

            for (int i = 1; i < 1000; i++)
            {
                //try
                //{
                //    int test = int.Parse((i / 3m).ToString());
                //    total += i;
                //    continue;

                //}
                //catch (Exception e)
                //{

                //}


                //try
                //{
                //    int test = int.Parse((i / 5m).ToString());
                //    total += i;
                //}
                //catch (Exception e)
                //{
                //}

                bool success3 = int.TryParse((i / 3m).ToString(), out int num3);
                bool success5 = int.TryParse((i / 5m).ToString(), out int num5);

                if (success3 || success5)
                    total += i;

            }

            Console.WriteLine(total);
        }
    }
}
