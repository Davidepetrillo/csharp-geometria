using Geometria;


// ---------- Variabili Globali -----------


Console.Write("Inserisci un numero che faccia da base per il tuo rettangolo: ");
int baseSceltaDalUtente = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Inserisci un numero che faccia da altezza per il tuo rettangolo: ");
int altezzaSceltaDallUtente = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Inserisci un numero che faccia da base per il tuo secondo rettangolo: ");
int secondaBaseSceltaDalUtente = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Inserisci un numero che faccia da altezza per il tuo secondo rettangolo: ");
int secondaAltezzaSceltaDallUtente = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Inserisci un numero che faccia da base per il tuo terzo rettangolo: ");
int terzaBaseSceltaDalUtente = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Inserisci un numero che faccia da altezza per il tuo terzo rettangolo: ");
int terzaAltezzaSceltaDallUtente = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("Inserisci un numero che faccia da base per il tuo quarto rettangolo: ");
int quartaBaseSceltaDalUtente = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("Inserisci un numero che faccia da altezza per il tuo quarto rettangolo: ");
int quartaAltezzaSceltaDallUtente = int.Parse(Console.ReadLine());
Console.WriteLine();


// ----------- Programma -----------


Rettangolo IlMioRettangolo = new Rettangolo(baseSceltaDalUtente, altezzaSceltaDallUtente);
RettangoloDue IlMioRettangoloDue = new RettangoloDue(secondaBaseSceltaDalUtente, secondaAltezzaSceltaDallUtente);
RettangoloTre IlMioRettangoloTre = new RettangoloTre(terzaBaseSceltaDalUtente, terzaAltezzaSceltaDallUtente);
RettangoloQuattro IlMioRettangoloQuattro = new RettangoloQuattro(quartaBaseSceltaDalUtente, quartaAltezzaSceltaDallUtente);



Console.WriteLine($"L'area del mio rettangolo è {IlMioRettangolo.CalcolaArea(baseSceltaDalUtente, altezzaSceltaDallUtente)}");
Console.WriteLine($"Il perimetro del mio rettangolo è {IlMioRettangolo.CalcolaPerimetro(baseSceltaDalUtente, altezzaSceltaDallUtente)}");
Console.WriteLine();
Console.WriteLine();








Console.WriteLine($"---------- Rettangolo2 ----------");
Console.WriteLine($" Base : {IlMioRettangoloDue.baseRettangoloDue} cm");
Console.WriteLine($" Altezza : {IlMioRettangoloDue.altezzaRettangoloDue} cm");
Console.WriteLine($" Perimetro : {IlMioRettangoloDue.CalcolaAreaDue(secondaBaseSceltaDalUtente, secondaAltezzaSceltaDallUtente)} cm");
Console.WriteLine($" Area : {IlMioRettangoloDue.CalcolaPerimetroDue(secondaBaseSceltaDalUtente, secondaAltezzaSceltaDallUtente)} cm2");
Console.WriteLine();


Console.WriteLine($"---------- Rettangolo3 ----------");
Console.WriteLine($" Base : {IlMioRettangoloTre.baseRettangoloTre} cm");
Console.WriteLine($" Altezza : {IlMioRettangoloTre.altezzaRettangoloTre} cm");
Console.WriteLine($" Perimetro : {IlMioRettangoloTre.CalcolaAreaTre(terzaBaseSceltaDalUtente, terzaAltezzaSceltaDallUtente)} cm");
Console.WriteLine($" Area : {IlMioRettangoloTre.CalcolaPerimetroTre(terzaBaseSceltaDalUtente, terzaAltezzaSceltaDallUtente)} cm2");
Console.WriteLine();

Console.WriteLine($"---------- Rettangolo4 ----------");
Console.WriteLine($" Base : {IlMioRettangoloQuattro.baseRettangoloQuattro} cm");
Console.WriteLine($" Altezza : {IlMioRettangoloQuattro.altezzaRettangoloQuattro} cm");
Console.WriteLine($" Perimetro : {IlMioRettangoloQuattro.CalcolaAreaQuattro(quartaBaseSceltaDalUtente, quartaAltezzaSceltaDallUtente)} cm");
Console.WriteLine($" Area : {IlMioRettangoloQuattro.CalcolaPerimetroQuattro(quartaBaseSceltaDalUtente, quartaAltezzaSceltaDallUtente)} cm2");
Console.WriteLine();



