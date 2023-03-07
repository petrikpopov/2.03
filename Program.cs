using System;
using System.Collections.Generic;

namespace HM02._03._2023
{
    class Poem
    {
        public string Name_Poem { get; set; }
        public string Name_Autor { get; set; }
        public int Year { get; set; }
        public string Text_Poem { get; set; }
        public string Topic_Poem { get; set; }

        public Poem() { }
        public Poem(string NP, string NA, int Y, string TP, string TOP )
        {
            Name_Poem = NP;
            Name_Autor = NA;
            Year = Y;
            Text_Poem = TP;
            Topic_Poem = TOP;
        }
        public void Enter()
        {
            Console.Write("Введите название стиха --->");
            Name_Poem = Convert.ToString(Console.ReadLine());
            Console.Write("Введите имя автора стиха --->");
            Name_Autor = Convert.ToString(Console.ReadLine());
            Console.Write("Введите год создания стиха --->");
            Year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите текст стиха --->");
            Text_Poem = Convert.ToString(Console.ReadLine());
            Console.Write("Введите тему стиха --->");
            Topic_Poem = Convert.ToString(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"Название стиха ---> {Name_Poem}\nИмя автора ---> {Name_Autor}\nГод создания стиха ---> {Year}\nТекст стиха ---> {Text_Poem}\nТема стиха ---> {Topic_Poem}\n");
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Poem poem = new Poem();
            poem.Enter();
            Console.WriteLine();
            poem.Show();

            List<Poem> list = new List<Poem>();
            list.Add(poem);
            list.Remove(poem);
            Console.WriteLine("");
            void Repl(Poem poem, string Text_Poem)
            {
                poem.Text_Poem = Text_Poem;
            }
            
            void Posc(Poem poem, string Name_Autor)
            {
                poem.Name_Autor = Name_Autor;
            }
        }

       
    }
}
