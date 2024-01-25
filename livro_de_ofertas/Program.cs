using System.Globalization;using System;
using System.Globalization;
using System.Collections.Generic;
public class Oferta
{
    public double Valores { get; set; }
    public int Quantidades { get; set; }

    public Oferta(double valores, int quantidades)
    {
        Valores = valores;
        Quantidades = quantidades;
    }
}

public class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Digite quantas entradas seram feitas: ");
        int n = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Digite os dados: posição,ação,valor,quantidade");
        List<Oferta> Livro = new List<Oferta>();
        const int Inserir = 0;
        const int Modificar = 1;
        const int Deletar = 2;
        for (int i = 0; i < n; i++)
        {
            string[] Entrada = Console.ReadLine().Split(',');
            int Posicao = int.Parse(Entrada[0]);
            int Acao = int.Parse(Entrada[1]);
            double Valor = double.Parse(Entrada[2], CultureInfo.InvariantCulture);
            int Quantidade = int.Parse(Entrada[3]);


            switch (Acao)
            {
                case Inserir:
                    Livro.Insert(Posicao - 1, new Oferta(Valor, Quantidade));
                    break;
                case Modificar:
                    if (Posicao - 1 < Livro.Count)
                    {
                        if (Valor != 0)
                            Livro[Posicao - 1].Valores = Valor;
                        if (Quantidade != 0)
                            Livro[Posicao - 1].Quantidades = Quantidade;
                    }
                    break;
                case Deletar:
                    if (Posicao - 1 < Livro.Count)
                        Livro.RemoveAt(Posicao - 1);
                    break;

            }
        }
        System.Console.WriteLine();
        System.Console.WriteLine("Tabela de Valores:");
        for (int i = 0; i < Livro.Count; i++)
        {
            Console.WriteLine($"{i + 1},{Livro[i].Valores},{Livro[i].Quantidades}");
        }
    }
}
