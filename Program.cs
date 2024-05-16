class Program
{
    static void Main(string[] args)
    {
        Csúcs startCsúcs;
        GráfKereső kereső;
        Console.WriteLine("A 3 szerzetes 3 kanibál problémát oldjuk meg.");
        startCsúcs = new Csúcs(new SzerzetesekÉsKannibálokÁllapot(3, 3));
        Console.WriteLine("A kereső egy 15 mélységi korlátos és emlékezetes backtrack.");
        kereső = new BackTrack(startCsúcs, 15, true);
        kereső.megoldásKiírása(kereső.Keresés());
        Console.WriteLine("A megoldáshoz elegendő: " + kereső.Keresés().GetMélység()
                          + " mélységi korlát is.");
        System.Console.WriteLine();
        Console.WriteLine("A kereső egy mélységi keresés körfigyeléssel.");
        kereső = new MélységiKeresés(startCsúcs, true);
        kereső.megoldásKiírása(kereső.Keresés());
        Console.ReadLine();
    }
}