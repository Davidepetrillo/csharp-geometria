using Geometria;
Console.Write("Inserisci un numero che faccia da base per il tuo rettangolo: ");
int baseSceltaDalUtente = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Inserisci un numero che faccia da base per il tuo rettangolo: ");
int altezzaSceltaDallUtente = int.Parse(Console.ReadLine());
Rettangolo IlMioRettangolo = new Rettangolo(baseSceltaDalUtente, altezzaSceltaDallUtente);

Console.WriteLine($"L'area del mio rettangolo è {IlMioRettangolo.CalcolaArea(baseSceltaDalUtente, altezzaSceltaDallUtente)}");
Console.WriteLine($"Il perimetro del mio rettangolo è {IlMioRettangolo.CalcolaPerimetro(baseSceltaDalUtente, altezzaSceltaDallUtente)}");