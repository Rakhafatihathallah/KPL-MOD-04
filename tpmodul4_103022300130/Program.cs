using System;
using System.Collections.Generic;

/*
class KodePos
{
    private static Dictionary<string, int> tabelKodePos = new Dictionary<string, int>
    {
        { "Batununggal", 40266 },
        { "Kujangsari", 40287 },
        { "Mengger", 40267 },
        { "Wates", 40256 },
        { "Cijaura", 40287 },
        { "Jatisari", 40286 },
        { "Margasari", 40286 },
        { "Sekejati", 40286 },
        { "Kebonwaru", 40272 },
        { "Maleer", 40274 },
        { "Samoja", 40273 }
    };

    public static int? getKodePos(string kelurahan)
    {
        if (tabelKodePos.TryGetValue(kelurahan, out int kodePos))
        {
            return kodePos;
        }
        else
        {
            return null; 
        }
    }
}

class MainClass
{
    public static void Main(string[] args)

    {

        Console.WriteLine("Daftar kelurahan yang tersedia:");

        List<string> kelurahanList = new List<string>
        {
            "Batununggal", "Kujangsari", "Mengger", "Wates", "Cijaura",
            "Jatisari", "Margasari", "Sekejati", "Kebonwaru", "Maleer", "Samoja"
        };

        for (int i = 0; i < kelurahanList.Count; i++)
        {
            Console.WriteLine($"- {kelurahanList[i]}");
        }

        Console.Write("Masukkan nama kelurahan: ");
        string kelurahan = Console.ReadLine();

        int? kodePos = KodePos.getKodePos(kelurahan);

        if (kodePos.HasValue)
        {
            Console.WriteLine($"Kode Pos {kelurahan} adalah {kodePos}");
        }
        else
        {
            Console.WriteLine("Kelurahan tidak ditemukan.");
        }
    }
}
*/

public enum DoorState
{
    terkunci,
    terbuka
}

public class DoorMachine
{
    DoorState state;

    public DoorMachine()
    {
        state = DoorState.terkunci;
    }


    public void bukaPintu()
    {
        if (state == DoorState.terkunci) {

            state = DoorState.terbuka;
            Console.WriteLine("Membuka pintu!");

        } else {
            Console.WriteLine("Pintu tidak terkunci!");
            Console.WriteLine("Membuka pintu...");
        }
    }

    public void kunciPintu()
    {

        if (state == DoorState.terkunci)
        {
            Console.WriteLine("Pintu sudah terkunci!");
        }
        else {
            state = DoorState.terkunci;
            Console.WriteLine("Sukses mengunci pintu!");
        }
    }
}

class Program
{
    public static void Main(String[] args) {

        DoorMachine door = new DoorMachine();

        Console.WriteLine("Mencoba mengunci pintu\n");
        door.kunciPintu();

        Console.WriteLine("Mencoba membuka pintu\n");
        door.bukaPintu();
    }

}
