using System;

namespace SuperHeroi
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int a = 0; a < 5; a++)
            {
                Voar(a);
            }
        }

        public static void Voar(int v)
        {
            int voar = v;

            var sHeroi = new SuperHeroi()
            {
                nome = "Super Man",
                nascimento = DateTime.Now.AddYears(-40),
                kryptonita = voar
            };

            if (sHeroi.kryptonita < 2)
            {
                Console.WriteLine(sHeroi.kryptonita + " Voando...");
            }
            else
            {
                Console.WriteLine(sHeroi.kryptonita + " Não Voando...");
            }
        }
        public class SuperHeroi
        {
            public string nome { get; set; }
            public DateTime nascimento { get; set; }
            public int kryptonita { get; set; }
        }
    }
}
