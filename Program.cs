namespace Problema_12_ED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do
            {
                Console.WriteLine("Ingrese la dimensión del CUbo Magico (DEBE SER IMPAR Y POSITIVO): ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0 || n == 0)
                {
                    Console.WriteLine("ERROR La dimensión debe ser impar");
                }
            }
            while (n % 2 == 0);

            int[,] CUBOMAGICO = new int[n, n];

            int l = 0;
            int k = n / 2;
            CUBOMAGICO[0, k] = 1;

            for (int i = 2; i <= n * n; i++)
            {
                int L = l;
                int K = k;

                if (l == 0)
                {
                    L = n - 1;
                }
                else
                {
                    L--;
                }

                if (k == n - 1)
                {
                    K = 0;
                }
                else
                {
                    K++;
                }

                if (CUBOMAGICO[L, K] == 0)
                {
                    l = L;
                    k = K;
                }
                else
                {
                    if (l == n - 1)
                    {
                        l = 0;
                    }
                    else
                    {
                        l++;
                    }
                }

                CUBOMAGICO[l, k] = i;
            }

            Console.WriteLine("CUADRO MAGICO:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(CUBOMAGICO[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    
}
    }
