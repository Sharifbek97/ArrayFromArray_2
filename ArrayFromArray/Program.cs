// See https://aka.ms/new-console-template for more information
//var nums = new int[22];


var E = new int[4][];

    var rnd = new Random();
for (var i = 0; i < E.Length; i++)
{
    E[i] = new int[4];
    for (var j = 0; j < E[i].Length; j++)
    {
        /*if (i == j)
        {
            E[i][j] = 0;
            Console.Write(E[i][j]+"  ");
        }
        else
        {
            E[i][j] = rnd.Next(20, 29);
            Console.Write(E[i][j] + "  ");
        }*/
        
        
        E[i][j] = i==j? 0 : rnd.Next(20, 29);
        Console.Write(E[i][j] + "  ");
    }

    Console.WriteLine();
}