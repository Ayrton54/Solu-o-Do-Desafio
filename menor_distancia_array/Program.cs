using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite os elementos do primeiro array, separados por vírgula, Exemplo:-1,5");
        string[] Entrada1 = Console.ReadLine().Split(',');
        int[] Array1 = Array.ConvertAll(Entrada1, int.Parse);

        Console.WriteLine("Digite os elementos do segundo array, separados por vírgula, Exemplo: 26,6:");
        string[] Entrada2 = Console.ReadLine().Split(',');
        int[] Array2 = Array.ConvertAll(Entrada2, int.Parse);

        int MenorDistancia = Program.MenorDistancia(Array1, Array2);
        Console.WriteLine($"A menor distância entre os elementos foi: {MenorDistancia}");
    }

    public static void Ordenacao(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            for (int j = 0; j < Array.Length - 1; j++)
            {
                if (Array[j] > Array[j + 1])
                {
                    int Temp = Array[j];
                    Array[j] = Array[j + 1];
                    Array[j + 1] = Temp;
                }
            }
        }
    }

    public static int MenorDistancia(int[] Array1, int[] Array2)
    {
        Ordenacao(Array1);
        Ordenacao(Array2);
        int i = 0, j = 0;
        int MenorDiferenca = int.MaxValue;
        while (i < Array1.Length && j < Array2.Length)
        {
            int dist;
            if (Array1[i] > Array2[j])
            {
                dist = Array1[i] - Array2[j];
            }
            else
            {
                dist = Array2[j] - Array1[i];
            }
            if (dist < MenorDiferenca)
            {
                MenorDiferenca = dist;
            }
            if (Array1[i] < Array2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }
        return MenorDiferenca;
    }
}
