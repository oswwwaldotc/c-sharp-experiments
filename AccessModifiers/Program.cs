using accessmodifiers_00;

namespace accessmodifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string date_ = DateTime.UtcNow.ToString("yyyy-MM-dd hh:mm:ss");
            Console.WriteLine("Using Codespaces :: my workspace in the cloud (GitHub) \n " + date_);
            
            //Con diferente namespace
            OneMoreClass one = new();

            one.PublicMethod();
            one.InternalMethod();

            Console.WriteLine(" :::::::::::::::::::: \n ");
            Arrays objectArray  = new();

            objectArray.arraysMethod();
            objectArray.exampleMethod();
            objectArray.Excercise();
        }
    }
}
