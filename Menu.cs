using System;
using System.Collections;

namespace EditorHtml
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();
            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);
        }

        public static void DrawScreen()
        {
            RenderLine(30, '-', '+', '+');

            for (int lines = 0; lines <= 10; lines++)
            {
                RenderLine(30, ' ', '|', '|');
            }
            RenderLine(30, '-', '+', '+');
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(3, 2);
            Console.WriteLine("Editor HTML");
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("==================");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("Selecione uma opção abaixo");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("1 - Novo arquivo");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("2 - Abrir");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("0 - Sair");
            Console.SetCursorPosition(3, 10);
            Console.Write("Opção: ");
        }

        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    Editor.Show();
                    break;
                case 2:
                    new Viewer().Show("");
                    break;
                case 0:
                {
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                }
            }
        }

        public static void RenderLine(int size, char commonChar, char? initialChar = null, char? finalChar = null)
        {
            if (initialChar.HasValue)
            {
                Console.Write(initialChar);
            }

            for (var i = 0; i < size; i++)
            {
                Console.Write(commonChar);
            }

            if (finalChar.HasValue)
            {
                Console.Write(initialChar);
            }
            Console.Write("\n");
        }
    }
}