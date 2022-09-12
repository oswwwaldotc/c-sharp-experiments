namespace MyProject
{
    class Program
    {
        private const string Format = "{0} x {1} = {2}";

        static void Main(string[] args)
        {
            //int numero = 10 * 5;
            //string numero = Console.ReadLine();
            Console.WriteLine("Do While - exercise");
            int numero = int.Parse(Console.ReadLine());

            /*int iterator = 1;
            int k = 1;
            do
            {
                Console.WriteLine("{0} x {1} = {2}", numero, k, numero * iterator);
                iterator++;
                k++;
            } while (k >= 10);*/

            Console.WriteLine("\nFor");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(Format, numero, i, numero * i);
            }

            short short_number = 140;
            float n_float = 123.5f;

            char c = 'e';
            string cc = "ee";
            bool state_ = false;

            //Placeholder
            Console.WriteLine("\nvalue: {0} value: {1} value float: {2} value bool: {3} ", numero, short_number, n_float, state_);

            Console.WriteLine(c);

            // Continue this
            if (state_ == true)
            {
                Console.WriteLine(state_);
            }
            else if (state_)
            {
                Console.WriteLine("!= {0} ", state_);
            }

            //only with strings?
            switch (cc)
            {
                case "ee":
                    Console.WriteLine("Is normal");
                    break;

                default:
                    Console.WriteLine("breakpoint in switch");
                    break;
            }
        }
    }
}