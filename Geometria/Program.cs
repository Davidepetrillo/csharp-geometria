using Geometria;


// ---------- Variabili Globali -----------


Console.Write("Inserisci un numero che faccia da base per il tuo rettangolo: ");
int baseSceltaDalUtente = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Inserisci un numero che faccia da base per il tuo rettangolo: ");
int altezzaSceltaDallUtente = int.Parse(Console.ReadLine());


// ----------- Programma -----------


Rettangolo IlMioRettangolo = new Rettangolo(baseSceltaDalUtente, altezzaSceltaDallUtente);
RettangoloDue IlMioRettangoloDue = new RettangoloDue(8, 4);
RettangoloTre IlMioRettangoloTre = new RettangoloTre(10, 5);
RettangoloQuattro IlMioRettangoloQuattro = new RettangoloQuattro(12, 8);


Console.WriteLine($"L'area del mio rettangolo è {IlMioRettangolo.CalcolaArea(baseSceltaDalUtente, altezzaSceltaDallUtente)}");
Console.WriteLine($"Il perimetro del mio rettangolo è {IlMioRettangolo.CalcolaPerimetro(baseSceltaDalUtente, altezzaSceltaDallUtente)}");
Console.WriteLine();
Console.WriteLine();


Console.WriteLine($"---------- Rettangolo1 ----------");
Console.WriteLine($" Base : {IlMioRettangolo.baseRettangolo} cm");
Console.WriteLine($" Altezza : {IlMioRettangolo.altezzaRettangolo} cm");
Console.WriteLine($" Perimetro : {IlMioRettangolo.CalcolaArea(baseSceltaDalUtente, altezzaSceltaDallUtente)} cm");
Console.WriteLine($" Area : {IlMioRettangolo.CalcolaPerimetro(baseSceltaDalUtente, altezzaSceltaDallUtente)} cm2");
Console.WriteLine();


Console.WriteLine($"---------- Rettangolo2 ----------");
Console.WriteLine($" Base : {IlMioRettangoloDue.baseRettangoloDue} cm");
Console.WriteLine($" Altezza : {IlMioRettangoloDue.altezzaRettangoloDue} cm");
Console.WriteLine($" Perimetro : {IlMioRettangoloDue.CalcolaAreaDue(8, 4)} cm");
Console.WriteLine($" Area : {IlMioRettangoloDue.CalcolaPerimetroDue(8, 4)} cm2");
Console.WriteLine();


Console.WriteLine($"---------- Rettangolo3 ----------");
Console.WriteLine($" Base : {IlMioRettangoloTre.baseRettangoloTre} cm");
Console.WriteLine($" Altezza : {IlMioRettangoloTre.altezzaRettangoloTre} cm");
Console.WriteLine($" Perimetro : {IlMioRettangoloTre.CalcolaAreaTre(10, 5)} cm");
Console.WriteLine($" Area : {IlMioRettangoloTre.CalcolaPerimetroTre(10, 5)} cm2");
Console.WriteLine();

Console.WriteLine($"---------- Rettangolo4 ----------");
Console.WriteLine($" Base : {IlMioRettangoloQuattro.baseRettangoloQuattro} cm");
Console.WriteLine($" Altezza : {IlMioRettangoloQuattro.altezzaRettangoloQuattro} cm");
Console.WriteLine($" Perimetro : {IlMioRettangoloQuattro.CalcolaAreaQuattro(12, 8)} cm");
Console.WriteLine($" Area : {IlMioRettangoloQuattro.CalcolaPerimetroQuattro(12, 8)} cm2");
Console.WriteLine();



