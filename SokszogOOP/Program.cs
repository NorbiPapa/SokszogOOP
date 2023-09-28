using SokszogOOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



Haromszog haromszog = new Haromszog();
Haromszog haromszog1 = new Haromszog(3, 4, 5);
Teglalap teglalap = new Teglalap(3, 5);
Teglalap teglalap1 = new Teglalap(4, 2);
Paralelogramma paralelogramma=new Paralelogramma();

Console.WriteLine(haromszog);
Console.WriteLine(haromszog1);
Console.WriteLine(teglalap);
Console.WriteLine(teglalap1);

Console.WriteLine(haromszog1.A);
try
{
    haromszog1.A = 10;
    Console.WriteLine(haromszog1.A);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine(haromszog1);
Console.WriteLine("----------");
Console.WriteLine("Paralelogramma:");
Console.WriteLine(paralelogramma);



