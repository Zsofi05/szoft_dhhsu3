// A véletlenszámokhoz szükség van egy generátorra (RNG = Random Number Generator)
// AZ alábbi sor csak ezt hozza létre, tényleges véletlen számot még nem generál
// A konstruktoron kívül érdemes példányosítani, mert ebbõl csak 1-et akarunk létrehozni 
// (Bonyolultabb problémák esetén van értelme többet létrehozni, de ahhoz nagyon érteni kell a mûködésüket, egyszerûbb követni azt a szabályt, hogy ebbõl MINDIG csak 1 legyen)
Random rng = new Random();

public Form1()
{
    InitializeComponent();

    // Ciklus, ami létrehozza majd a gombokat
    for (int i = 0; i < 1000; i++)
    {
        // A tényleges randomszám generáláshoz a random generátor Next metódusát kell használnunk
        // Ennek két bemenõ paramétere van, melyek megadják, hogy mely két érték között legyen a véletlenszám
        // Vigyázat a felsõ korlát exkluzív, tehát ezt az értéket már nem veheti fel a véletlenszám
        // Pl.: rng.Next(1, 10) esetén 1-tõl 9-ig bármelyik számot kaphatjuk eredményként, de a 10-et már nem
        // Az elsõ paraméter elhagyható, ekkor a minimum 0 lesz és csak a maximumot kell megadni
        // Ha tört számra van szükség, akkor a NextDouble() metódus visszaad egy 0 és 1 közti tizedes törtet
        // Ezt felszorozva bármilyen két érték közti racionális számot elõ lehet állítani

        // Az átláthatóság érdekében létrehozunk változókat a véletlen számok tárolására
        // Ezeknek a változóknak létrehozása kihagyható, az értékadásuk egyszerûen beírható oda, ahol késõbb hivatkozunk rájuk

        // Aktuális gomb mérete
        // Ebben a példában a gomb szélessége és magassága véletlen szerûen 20 és 50 között van               
        int width = rng.Next(20, 51);
        int height = rng.Next(20, 51);

        // Aktuális gomb pozíciója
        // A pozíciók minimuma nulla, ezért használható a Next azon változata, ahol csak a maximum értéket kell megadni
        // A szélesség maximum értéke a Form szélessége, de ebbõl le kell vonni az aktuális gomb szélességét, különben elõfordulhatna, hogy a gomb kilóg a Form-ról
        // A ClientSize.Width a Form belsõ méretét adja míg a sima Width a külsõ keretet is számba veszi ezért pontatlanabb
        int left = rng.Next(this.ClientSize.Width - width);
        int top = rng.Next(this.ClientSize.Height - height);

        // Aktuális gomb színe
        // A szín meghatározásához az RGB kódra van szükségünk
        // Ez három darab 0-255 közti számból áll
        int r = rng.Next(256);
        int g = rng.Next(256);
        int b = rng.Next(256);

        // A véletlen számok legenerálása után egyszerûen létrehozható a gomb
        Button gomb = new Button();
        gomb.Width = width;
        gomb.Height = height;
        gomb.Left = left;
        gomb.Top = top;
        gomb.BackColor = Color.FromArgb(r, g, b);
        this.Controls.Add(gomb);
    }
}