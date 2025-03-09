using System;

class Program
{
    static void Main(string[] args)
    {
        
        KodePos kodePos = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kodePos.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Cijaura: " + kodePos.GetKodePos("Cijaura"));

        
        DoorMachine door = new DoorMachine();
        door.Unlock();
        door.Lock();
    }
}
