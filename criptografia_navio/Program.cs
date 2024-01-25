using System;

class Program
{
    static void Main()
    {
        string[] MensagemSecreta = { "10010110", "11110111", "01010110", "00000001",
        "00010111", "00100110", "01010111", "00000001", "00010111", "01110110",
        "01010111", "00110110", "11110111", "11010111", "01010111", "00000011" };

        foreach (var item in MensagemSecreta)
        {
            string InverteBits = Program.InverteBits(item);
            char Descriptografar = CriandoCaractere(InverteBits);
            Console.Write(Descriptografar);
        }

    }

    static string InverteBits(string Bits)
    {

        char[] Array = Bits.ToCharArray();
        Array[6] = Array[6] == '0' ? '1' : '0';
        Array[7] = Array[7] == '0' ? '1' : '0';
        string InverteDoisUltimos = new string(Array);


        return InverteDoisUltimos.Substring(4, 4) + InverteDoisUltimos.Substring(0, 4);
    }


    static char CriandoCaractere(string Binario)
    {
        int Ascii = Convert.ToInt32(Binario, 2);
        return (char)Ascii;
    }
}
