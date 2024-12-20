using System;
using System.Text;

namespace EditorHtml
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("------------");
            Start();
        }

        public static void Start()
        {
            var file = new StringBuilder();

            do {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("------------");
            Console.WriteLine(" Deseja Salvar o arquivo? S / N");
            var option = Console.ReadKey();

            if(option.Key == ConsoleKey.S) {
                using(StreamWriter writer = new StreamWriter(Path.Combine(AppContext.BaseDirectory, "arquivo.html"))) {
                    writer.Write(file.ToString());
                }

                new Viewer().Show(file.ToString());
            }
        }
    }
}