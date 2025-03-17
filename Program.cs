// See https://aka.ms/new-console-template for more information
int adultosComBebida = 0, adultosSemBebida = 0, criancas = 0;

Console.Write("Adultos que consomem bebidas alcoólicas.......: ");
adultosComBebida = int.Parse(Console.ReadLine());

Console.Write("Adultos que não consomem bebidas alcoólicas...: ");
adultosSemBebida = int.Parse(Console.ReadLine());

Console.Write("Crianças........................................: ");
criancas = int.Parse(Console.ReadLine());


int totaladutos = adultosComBebida + adultosSemBebida;

double carneGramas = totalAdultos * 400 + criancas * 200;
double carneKg = carneGramas / 1000.0;

double acompGramas = (totalAdultos + criancas) * 200;
double acompKg = acompGramas / 1000.0;

double cervejaLitros = adultosComBebida * 2.0;

double refriMl = (adultosSemBebida + criancas) * 500.0;
double refriLitros = refriMl / 1000.0;

double aguaMl = (totalAdultos + criancas) * 400.0;
double aguaLitros = aguaMl / 1000.0;

Console.WriteLine();
Console.WriteLine($"Carne.............: {carneKg:F1}kg");
Console.WriteLine($"Acompanhamentos...: {acompKg:F1}kg");
Console.WriteLine($"Cerveja...........: {cervejaLitros:F1}l");
Console.WriteLine($"Refrigerante......: {refriLitros:F1}l");
Console.WriteLine($"Água..............: {aguaLitros:F1}l");