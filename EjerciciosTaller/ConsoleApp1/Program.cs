//// See https://aka.ms/new-console-template for more information
using Exercise.Logic;
Console.WriteLine("Excercise 33");
var ex33 = new Ex33(m1(), n1(), p1());

Console.WriteLine("*** A ***");
ex33.FillA();
Console.WriteLine(ex33);
ex33.FillB();
Console.WriteLine("*** B ***");
Console.WriteLine(ex33.PrintB());
Console.WriteLine("*** C ***");
ex33.FillC();
Console.WriteLine(ex33.PrintC());

int m1()
{
    Console.Write("Ingrese el valor de m: ");
    var m = Console.ReadLine();
    return Convert.ToInt32(m);
}

int n1()
{
    Console.Write("Ingrese el valor de n: ");
    var n = Console.ReadLine();
    return Convert.ToInt32(n);
}
int p1()
{
    Console.Write("Ingrese el valor de p: ");
    var p = Console.ReadLine();
    return Convert.ToInt32(p);

}
Console.ReadKey();
Console.WriteLine("Excercise 34\n");

var ex34 = new Ex34(Mat());
Console.WriteLine("MATRIZ COMPLETA");
ex34.Fill();
Console.WriteLine(ex34);
Console.WriteLine("\nRELOJ DE ARENA");
Console.WriteLine(ex34.Hourglass());

Console.ReadKey();
Console.WriteLine("Excercise 35\n");

var esx35 = Ex35.Factors(factor());

foreach (var item in esx35)
{
    Console.Write($" {item} X");
}
int factor()
{
    Console.Write("Ingrese el número a descomponer: ");
    var m = Console.ReadLine();
    return Convert.ToInt32(m);
}
int Mat()
{
    Console.Write("IIngrese orden de la matriz: ");
    var m = Console.ReadLine();
    return Convert.ToInt32(m);
}




