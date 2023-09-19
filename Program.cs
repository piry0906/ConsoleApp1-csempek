// See https://aka.ms/new-console-template for more information
using System;

class Program {
    static void Main() {
        Console.WriteLine("Kérjük, adja meg a terület szélességét méterben:");
        double szelesseg = double.Parse(Console.ReadLine());

        Console.WriteLine("Kérjük, adja meg a terület magasságát méterben:");
        double magassag = double.Parse(Console.ReadLine());

        // A terület méretének kiszámítása négyzetméterben
        double terulet = szelesseg * magassag;

        // A csempeméret 20x20 cm, de a plusz 10%-ot is hozzáadjuk
        double csempemagassag = 0.2; // 20 cm méterben
        double cseppszlesseg = 0.2; // 20 cm méterben
        double illesztes = 1.1; // 100% + 10% illesztés

        // Szükséges csempék számának kiszámítása
        double szuksegesCsempek = (terulet * illesztes) / (csempemagassag * cseppszlesseg);

        Console.WriteLine($"Szükséges csempék száma: {Math.Ceiling(szuksegesCsempek)} darab");

        Console.ReadLine(); // Várakozás, hogy a felhasználó láthassa az eredményt
    }
}