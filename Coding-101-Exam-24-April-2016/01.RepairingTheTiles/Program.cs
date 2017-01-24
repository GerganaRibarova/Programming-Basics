using System;

namespace _01.RepairingTheTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var nPloshtadka = double.Parse(Console.ReadLine());
            var wTile = double.Parse(Console.ReadLine());
            var lTile = double.Parse(Console.ReadLine());
            var wPeika = double.Parse(Console.ReadLine());
            var lPeika = double.Parse(Console.ReadLine());

            double tile = wTile * lTile;
            double plosht = nPloshtadka * nPloshtadka - wPeika * lPeika;
            Console.WriteLine(plosht / tile);
            Console.WriteLine(plosht / tile * 0.2);
        }
    }
}
