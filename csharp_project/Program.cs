using csharp_project;

namespace MyProject
{
    class Program
    {
        private const string Format = "{0} x {1} = {2}";

        static void Main(string[] args)
        {
            //Static
            Account.Bank = "Old Bank";
            Account.UpdateBank("New Bank");
            Console.WriteLine(Account.Bank);

            //Property
            Account account_mock = new Account();
            account_mock.Price = -5;
            Console.WriteLine("Account mock Price:{0}", account_mock.Price);

            //Constructors 
            Account account_01 = new Account("A100","Red", 100m);
            account_01.MoreBucks(70);
            Console.WriteLine("\nAccount 01:{0}   User:{1}   Price:{2}", account_01.Number_Account, account_01.Name_Account, account_01.Price);

            Account account_02 = new Account("B200", "Blue", 250m);
            account_02.LessBucks(20);
            //Override the method
            Console.WriteLine(account_02.ToString());
 
            //Call from another class
            Rectangle rectangle_ = new Rectangle();
            Console.WriteLine("\nRectangle 01: {0}", rectangle_.CalculateArea(4, 5));

            Rectangle rectangle_02 = new Rectangle { x_base = 15, y_height = 10 };
            Console.WriteLine("Rectangle 02: {0}", rectangle_02);

            //int numero = int.Parse(Console.ReadLine());
            int numero = 10;

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