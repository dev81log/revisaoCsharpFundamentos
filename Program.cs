using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Cotacao cotacao = new Cotacao(10, "Dolar Canadense", 5.14);
            cotacao.Id = 15;
            cotacao.Moeda = "Dolar Canadense!";
            cotacao.Preco = 5.16;

            Console.WriteLine(cotacao.Id);
            Console.WriteLine(cotacao.Moeda);
            Console.WriteLine(cotacao.Preco);

            var meuNome = RetornaNome("Asher", "Duarte");
            Console.WriteLine(meuNome);

            double x = 2;
            x = 75 / 21;
            Console.WriteLine(x);

            float tempo = 2.0f;
            Console.WriteLine(tempo);

            float novaPrevisão = 10.0f;
            if (novaPrevisão <= tempo)
            {
                tempo++;
                Console.WriteLine(tempo);
            }
            else
            {
                Console.WriteLine("Tempo é inferior");
            }

            int nota = 10;
            for (int i = 0; nota > i; i++)
            {
                Console.WriteLine(i);
            }

            while (nota <= 12)
            {
                Console.WriteLine("ainda é menor");
                nota++;
            }
        }

        static string RetornaNome(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
    }

    struct Cotacao
    {
        public Cotacao(int id, string moeda, double preco)
        {
            Id = id;
            Moeda = moeda;
            Preco = preco;
        }

        public int Id;
        public string Moeda;
        public double Preco;

        public double ConversorDolar(double dolar)
        {
            return dolar * Preco;
        }
    }
}

