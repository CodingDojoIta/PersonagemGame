using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem p1 = new Personagem();
            p1.CreatePersonagem(contaPremium: true, nome: "João", roupaCor: "Orange");
            Console.WriteLine(p1.StatusPersonagem());

            Personagem p2 = new Personagem();
            p2.CreatePersonagem(contaPremium: false, nome: "Maria", roupaCor: "Black", cabeloCor: "Yellow");
            Console.WriteLine(p2.StatusPersonagem());

            Personagem p3 = new Personagem();
            p3.CreatePersonagem(contaPremium: false, nome: "José", roupaCor: "Black", cabeloCor: "Yellow");
            Console.WriteLine(p3.StatusPersonagem());

            Console.ReadKey();
            Console.Clear();
        }        
    }
}
