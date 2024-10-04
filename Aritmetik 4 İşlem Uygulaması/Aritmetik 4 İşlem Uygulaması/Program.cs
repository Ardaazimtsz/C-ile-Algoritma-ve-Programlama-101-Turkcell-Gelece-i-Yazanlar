// See https://aka.ms/new-console-template for more information

namespace MyNamespace
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int s1, s2, toplam, fark, carpma, bolme;
            Console.WriteLine("*****Aritemtik İşlemleri******* ");
            Console.WriteLine(" ");
            s1 = 20;
            s2 = 30;
            toplam = s1 + s2;
            fark = s1 - s2;
            carpma = s1 * s2;
            bolme = s1 / s2;
            Console.WriteLine("Toplam: "+ toplam);
            Console.WriteLine("Farklar: "+ fark);
            Console.WriteLine("Carpma: "+ carpma);
            Console.WriteLine("Bolme: "+ bolme);
            Console.WriteLine();
            Console.Write("*****Aritemtik İşlemleri******* ");
            Console.Read();

        }
    }
}