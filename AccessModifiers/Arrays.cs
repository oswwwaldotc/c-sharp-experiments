using accessmodifiers;

class Arrays
{
    public void arraysMethod()
    {
        //string nameMethod = '';
        Console.WriteLine("I'm here inside of {0}", nameof(arraysMethod));
    }

    public void exampleMethod()
    {
        //string nameMethod = '';
        Console.WriteLine("I'm here inside of {0}", nameof(exampleMethod));

        //Son objetos en C#
        int[] example = new int[3];
        example[0] = 34;
        example[1] = 45;
        example[2] = 89;

        for (int i = 0; i < example.Length; i++)
        {
            Console.WriteLine("\nINT :: Value iterator:{0} value:{1}", i, example[i]);
        }

        char[] vocales = new char[] { 'a', 'e', 'i', 'o', 'u' };
        for (int i = vocales.Length-1; i >= 0; i--)
        {
            Console.WriteLine("\nCHAR :: Value iterator:{0} value:{1}", i, vocales[i]);
        }

        double[] numerous = { 1.4, 4.7, 3.9, 9.2, 5.5, 3.9, 2.2 };
        /*for (int i = 0; i < numerous.Length; i++)
        {
            Console.WriteLine("\nDOUBLE :: Value iterator:{0} value:{1}", i, numerous[i]);
        }*/

        Console.WriteLine("\nDOUBLE Foreach");
        foreach (double item in numerous)
        {
            Console.WriteLine(item);
        }
        //Console.WriteLine(numerous[numerous.Length-1]);
    }

    public void Excercise(){
        Console.Write("Tamaño del array ");
        int tam = Convert.ToInt32(Console.ReadLine());

        int[] numeros_ = new int[tam];

        for (int i = 0; i < numeros_.Length; i++)
        {
            Console.Write("Ingresar numeros ");
            numeros_[i] = Convert.ToInt32(Console.ReadLine());
        }

        foreach (int item in numeros_)
        {
            Console.WriteLine(item);

            
        }

        /*
            Es static por ende se utiliza asi:
            Array.Copy(origen, copiado, origen.length)
            Arrary.Reverse(copiado)
            Array.Sort(origen) -> Utilizando ascendente

        */
    }
}