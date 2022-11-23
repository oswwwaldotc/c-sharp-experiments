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
        for (int i = vocales.Length - 1; i >= 0; i--)
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

    public void Excercise()
    {
        Console.WriteLine("\nI'm here inside of {0}", nameof(Excercise));

        Console.Write("\nTamaño del array (calificaciones) ");
        int tam = Convert.ToInt32(Console.ReadLine());

        int[] numeros_ = new int[tam];
        double averageTemp = 0;

        for (int i = 0; i < numeros_.Length; i++)
        {
            Console.Write("Ingresar numeros ");
            numeros_[i] = Convert.ToInt32(Console.ReadLine());
            averageTemp += numeros_[i];
        }

        //foreach (int item in numeros_)
        //{
        //    Console.WriteLine("Mostrando los elementos {0}",item);
        //}

        Console.WriteLine("Average {0}", averageTemp / tam);

        /*
            Es static por ende se utiliza asi:
            Array.Copy(origen, copiado, origen.length)
            Arrary.Reverse(copiado)
            Array.Sort(origen) -> Utilizando ascendente

        */
    }

    public void Multidimensiones()
    {
        int[,] ints = new int[3, 2] { { 0, 1 }, { 2, 3 }, { 4, 5 } };

        //Toma la dimension, en este caso es 3 o i
        //                                   2 o j 
        Console.WriteLine("\nI'm here inside of {0}", nameof(Multidimensiones));
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                Console.WriteLine("{0}-{1} :: {2}", i, j, ints[i, j]);
            }
        }

        Console.WriteLine("\nNew array 3x3");
        double[,] doublesMulti = new double[3, 3] { { 1.1, 2.6, 3.8 }, { 2.6, 3.3, 9.3 }, { 4.7, 5.3, 1.5 } };
        for (int i = 0; i < doublesMulti.GetLength(0); i++)
        {
            for (int j = 0; j < doublesMulti.GetLength(1); j++)
            {
                Console.Write(" {0} ", doublesMulti[i,j]);
            }
            Console.WriteLine();
        }

        //Console.WriteLine("\nArray null");
        //int[,] exampleNull = new int[5, 5];
        //for (int i = 0; i < exampleNull.GetLength(0); i++)
        //{
        //    for (int j = 0; j < exampleNull.GetLength(1); j++)
        //    {
        //        Console.Write(" {0} ", exampleNull[i, j]);
        //    }
        //    Console.WriteLine();
        //}

        double[,] matrixA = new double[2, 2] { { 4, 2.6} , { 2.6, 3} };
        double[,] matrixB = new double[2, 2] { { 7.6, 4 }, { 9, 5.5 } };

        Console.WriteLine("\nA:: Array 2x2");
        DisplayMtrix(matrixA);
        
        Console.WriteLine("\nB:: Array 2x2");
        DisplayMtrix(matrixB);

        double[,] suma = new double[2, 2];
        for (int i = 0; i < suma.GetLength(0); i++)
        {
            for (int j = 0; j < suma.GetLength(1); j++)
            {
                suma[i,j] = matrixA[i,j] + matrixB[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nC:: Sum 2x2");
        DisplayMtrix(suma);
    }

    static void DisplayMtrix(double[,] Matriz)
    {
        for (int i = 0; i < Matriz.GetLength(0); i++)
        {
            for (int j = 0; j < Matriz.GetLength(1); j++)
            {
                //Especificar de formato
                Console.Write(" {0:0.#0} ", Matriz[i, j]);
            }
            Console.WriteLine();
        }
    }

}