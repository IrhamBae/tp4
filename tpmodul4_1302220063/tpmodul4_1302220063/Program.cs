using System;

class KodePos
{
    private readonly Dictionary<string, string> kodePosTable;

    public KodePos()
    {
        kodePosTable = new Dictionary<string, string>()
        {
            {"Batununggal", "40266"},
            {"Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };
    }

    public string GetKodePos(string kelurahan)
    {
        if (kodePosTable.ContainsKey(kelurahan))
        {
            return kodePosTable[kelurahan];
        }
        else
        {
            return "Kode Pos Tidak Ditemukan";
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        // Contoh pemanggilan
        Console.WriteLine("Kode Pos untuk Kelurahan Batununggal: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos untuk Kelurahan Kujangsari: " + kodePos.GetKodePos("Kujangsari"));
        Console.WriteLine("Kode Pos untuk Kelurahan Mengger: " + kodePos.GetKodePos("Mengger"));
        Console.WriteLine("Kode Pos untuk Kelurahan Wates: " + kodePos.GetKodePos("Wates"));
        Console.WriteLine("Kode Pos untuk Kelurahan Cijaura: " + kodePos.GetKodePos("Cijaura"));
        Console.WriteLine("Kode Pos untuk Kelurahan Jatisari: " + kodePos.GetKodePos("Jatisari"));
        Console.WriteLine("Kode Pos untuk Kelurahan Margasari: " + kodePos.GetKodePos("Margasari"));
        Console.WriteLine("Kode Pos untuk Kelurahan Sekejati: " + kodePos.GetKodePos("Sekejati"));
        Console.WriteLine("Kode Pos untuk Kelurahan Kebonwaru: " + kodePos.GetKodePos("Kebonwaru"));
        Console.WriteLine("Kode Pos untuk Kelurahan Maleer: " + kodePos.GetKodePos("Maleer"));
        Console.WriteLine("Kode Pos untuk Kelurahan Samoja: " + kodePos.GetKodePos("Samoja"));
        Console.WriteLine();
    }
}