using System;

namespace Projeto_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Privet Brat");

            Console.WriteLine("Poshili pit' vodke moy drug?");

            string resposta = Console.ReadLine();

            while (resposta != "Davai davai brat" && resposta != "Njet Ya khotchu Koka Kola")
            {
                Console.WriteLine("Apenas aceitas respostas: <Davai davai brat> ou <Njet Ya khotchu Koka Kola> ");
                resposta = Console.ReadLine();
            }
            if (resposta == "Davai davai brat")
                Console.WriteLine("Россия – священная наша держава," +
                                  "Россия – любимая наша страна." +
                                  "Могучая воля, великая слава –" +
                                  "Твоё достоянье на все времена!" +

                                   "Припев:" +
                                   "Славься, Отечество наше свободное," +
                                   "Братских народов союз вековой," +
                                   "Предками данная мудрость народная!" +
                                   "Славься, страна! Мы гордимся тобой!" +

                                   "От южных морей до полярного края" +
                                   "Раскинулись наши леса и поля." +
                                   "Одна ты на свете! Одна ты такая –" +
                                   "Хранимая Богом родная земля!" +

                                   "Припев" +

                                   "Широкий простор для мечты и для жизни." +
                                   "Грядущие нам открывают года." +
                                   "Нам силу даёт наша верность Отчизне." +
                                   "Так было, так есть и так будет всегда!");
            else
                Console.WriteLine("IDI NA HUI SUKA AMERICANSKI YEBAL");

            Console.ReadLine();
        }
    }
}
