using ConceptsPOO;

Console.WriteLine("Hello, World!");
Console.WriteLine("=============");

try
{
   
    Console.WriteLine(new Date(12, 7, 2022));
    Console.WriteLine(new Date(23, 9, 1974));
    Console.WriteLine(new Date(45, 11, 1985));
    Console.WriteLine(new Date(31, 11, 2022));
}
catch (Exception Error)
{

    Console.WriteLine(Error.Message);
}

