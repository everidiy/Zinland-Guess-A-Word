using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Zinland_Guess_A_Word
{
    internal class Program
    {
        static void Main()
        {
            Intro();
            Thread.Sleep(200);
            StartGame();
        }


        //Интро
        static void Intro()
        {
            Console.Clear();

            string title = "ВОЛШЕБНЫЙ ОСТРОВ ЗИНЛЕНД";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(title);
            Console.ResetColor();
            Console.Write("\nНажмите любую клавишу для начала игры...");
            Console.ReadKey();
        }

        // Начало игры
        static void StartGame()
        {
            Console.Clear();
            Console.WriteLine("Приветствую тебя, великий путник, на земле волшебного острова Зинленд!");
            Thread.Sleep(300);
            Console.WriteLine("\nТвоей задачей является освободить несколько слов из тёмных оков зла!");
            Thread.Sleep(300);
            Console.WriteLine("\nТы готов начать это небольшое приключение? ");
            Thread.Sleep(500);
            Console.Write("\nКаков твой ответ? ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Да");
            Console.ResetColor();
            Console.Write(" / ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Нет\n");
            Console.ResetColor();


            string answer = Console.ReadLine();

            if (answer.ToLower() == "да")
            {
                ChooseCharacterClass();
            }
            else if (answer.ToLower() == "нет")
            {
                ExitGame();
            }
            else
            {
                HandleInvalidInput();
            }
        }



        // Выбор класса персонажа
        static void ChooseCharacterClass()
        {
            Console.Clear();
            Console.WriteLine("За какой класс персонажа ты будешь играть? ");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(P.S. - от этого зависит тема слов)");
            Console.WriteLine("(0 - Выход в главное меню, 1 - 10 - Тип персонажа)");
            Console.ResetColor();
            Console.WriteLine();

            Console.Write("\n");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" Волшебник ");
            Console.ResetColor();
            Console.Write("- хранитель скрижалей, читающий звёздные свитки ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("(1)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Лучник ");
            Console.ResetColor();
            Console.Write("- следопыт лунных троп, чья стрела не знает промаха ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("(2)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Рыцарь ");
            Console.ResetColor();
            Console.Write("- защитник чести с клинком из слова и щитом из клятвы ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("(3)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" Разбойник ");
            Console.ResetColor();
            Console.Write("- тень в ночи, ворующий не золото, а смыслы ");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("(4)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Бард ");
            Console.ResetColor();
            Console.Write("- голос таверн, оживляющий слова музыкой и историей ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("(5)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(" Алхимик ");
            Console.ResetColor();
            Console.Write("- преобразователь материи, смешивающий элементы в тигле вечности ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("(6)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(" Друид ");
            Console.ResetColor();
            Console.Write("- голос древнего леса, понимающий язык корней и звёзд ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("(7)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" Некромант ");
            Console.ResetColor();
            Console.Write("- дирижёр тишины, разговаривающий с тем, что было до слов ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("(8)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(" Инженер ");
            Console.ResetColor();
            Console.Write("- Архитектор невозможного, собирающий идеи как механизмы ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("(9)\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" Психик ");
            Console.ResetColor();
            Console.Write("- Картограф снов, читающий мысли как открытые книги ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("(10)\n");
            Console.ResetColor();

            string role = Console.ReadLine().ToLower();

            switch (role)
            {
                case "0":
                    StartGame();
                    break;
                case "1":
                    ShowMageIntro();
                    StartMageGame();
                    break;
                case "2":
                    ShowArcherIntro();
                    StartArcherGame();
                    break;
                case "3":
                    ShowKnightIntro();
                    StartKnightGame();
                    break;
                case "4":
                    ShowThiefIntro();
                    StartThiefGame();
                    break;
                case "5":
                    ShowBardIntro();
                    StartBardGame();
                    break;
                case "6":
                    ShowAlchimicIntro();
                    StartAlchimicGame();
                    break;
                case "7":
                    ShowDruidIntro();
                    StartDruidGame();
                    break;
                case "8":
                    ShowNecromantIntro();
                    StartNecromantGame();
                    break;
                case "9":
                    ShowEngeneerIntro();
                    StartуEngineerGame();
                    break;
                case "10":
                    ShowPsychoIntro();
                    StartPsychoGame();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Похоже ты ещё не определился :(");
                    Console.WriteLine("Понимаю, это довольно тяжело, давай попробуем ещё раз!");
                    Thread.Sleep(2000);
                    ChooseCharacterClass();
                    break;
            }
        }



        // Введение для Мага
        static void ShowMageIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("════════════════════════════════════════════");
            Console.WriteLine("            ИЗБРАННЫЙ ВОЛШЕБНИК         ");
            Console.WriteLine("════════════════════════════════════════════");
            Console.WriteLine("     Древние руны зовут хранителя тайн!");
            Console.WriteLine("  Твои слова - заклинания из звёздной пыли.");
            Console.WriteLine("Освободи слова силы, что спят в скрижалях");
            Console.WriteLine("    с начала времён в пещере Зинлэнда.");
            Console.WriteLine("════════════════════════════════════════════");
            Console.WriteLine("     МИССИЯ: оживить древние слова!  ");
            Console.WriteLine("════════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }



        // Введение для Лучника
        static void ShowArcherIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("            ЗВЕЗДНЫЙ ЛУЧНИК             ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("   Твой взор пронзает туман, как стрела!");
            Console.WriteLine(" Каждое слово - стрела, выпущенная под");
            Console.WriteLine("     пение лунного ветра. Найди слова");
            Console.WriteLine("     -стрелы в глубинах древнего леса.");
            Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine("    МИССИЯ: найти слова-стрелы лесов!   ");
            Console.WriteLine("══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }



        // Введение для Рыцаря
        static void ShowKnightIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("           РУНИЧЕСКИЙ РЫЦАРЬ            ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("      Твой щит - честь, твой меч - слово!");
            Console.WriteLine("      Защитник забытых истин. Слова станут");
            Console.WriteLine("    клинками света в битве с пустотой.");
            Console.WriteLine("   Выкуй заветы предков из камня вечности.");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("  МИССИЯ: выковать слова-доспехи чести!  ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }



        // Введение для Разбойника
        static void ShowThiefIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("         ТЕНЕВОЙ РАЗБОЙНИК СЛОВ            ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("        Крадешь не золото, а смыслы!");
            Console.WriteLine("   Пальцы скользят между реальностями,");
            Console.WriteLine("   выуживая слова из карманов забвения.");
            Console.WriteLine("   Каждое слово - ключ, похищенный у тьмы.");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("       МИССИЯ: украсть слова у зла     ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }



        // Введение для Барда
        static void ShowBardIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("════════════════════════════════════════════");
            Console.WriteLine("          БАРД ЗВУЧАЩИХ СЛОВ           ");
            Console.WriteLine("════════════════════════════════════════════");
            Console.WriteLine("   Лютня играет на струнах реальности!");
            Console.WriteLine("  Каждое слово станет нотой в симфонии мира.");
            Console.WriteLine(" Даёшь словам голос, чтобы они зазвучали");
            Console.WriteLine(" в унисон с песней звёзд и шёпотом ручьёв.");
            Console.WriteLine("════════════════════════════════════════════");
            Console.WriteLine("   МИССИЯ: спеть слова обратно к жизни!  ");
            Console.WriteLine("════════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }



        // Введение для Алхимика
        static void ShowAlchimicIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("           АЛХИМИК ВЕЧНОСТИ                ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("    Превращаешь свинец в золото мыслей!");
            Console.WriteLine("  Тигель твоего разума плавит реальность,");
            Console.WriteLine("  создавая эликсиры из букв и реактивов.");
            Console.WriteLine("  Каждое слово - философский камень духа.");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine(" МИССИЯ: создать совершенные формулы слов  ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }


        // Введение для Друида
        static void ShowDruidIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("           ДРУИД ДРЕВНИХ РОЩ              ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("   Слышишь шепот корней и пение ветров!");
            Console.WriteLine("   Твое сердце бьется в ритме сезонов,");
            Console.WriteLine("   а слова прорастают из семян истины.");
            Console.WriteLine("   Каждое слово - дерево мудрости мира.");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("    МИССИЯ: возродить слова природы      ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }


        // Введение для Некроманта
        static void ShowNecromantIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("            НЕКРОМАНТ ЗАБВЕНИЯ              ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("   Разговариваешь с тем, что молчало век!");
            Console.WriteLine("   Твои пальцы вьют паутину из тишины,");
            Console.WriteLine("   вытягивая слова из глубин небытия.");
            Console.WriteLine("   Каждое слово - воскресшая эпитафия.");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("   МИССИЯ: воскресить похороненные слова");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }


        // Введение для Инженера
        static void ShowEngeneerIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("            ИНЖЕНЕР МИРОЗДАНИЯ           ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("   Собираешь идеи как точные механизмы!");
            Console.WriteLine("   Шестеренки твоей логики сцепляются,");
            Console.WriteLine("   создавая машины из букв и смыслов.");
            Console.WriteLine("   Каждое слово - деталь вечного двигателя.");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("   МИССИЯ: построить слова-механизмы");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }


        // Введение для Психика
        static void ShowPsychoIntro()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("            ПСИХИК БЕЗДНЫ РАЗУМА          ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("   Читаешь мысли как открытые фолианты!");
            Console.WriteLine("   Твое сознание плавает в океане идей,");
            Console.WriteLine("   вылавливая слова из потоков подсознания.");
            Console.WriteLine("   Каждое слово - нейронная вспышка истины.");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.WriteLine("   МИССИЯ: расшифровать слова разума    ");
            Console.WriteLine("═══════════════════════════════════════════");
            Console.ResetColor();
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }



        // Загрузка
        static void Loading()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n     Загрузка");

            for (int wave = 0; wave < 2; wave++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(500);
                    Console.Write(".");
                }
                if (wave < 1)
                {
                    Thread.Sleep(500);
                    int cursorLeft = Console.CursorLeft - 3;
                    int cursorTop = Console.CursorTop;

                    Console.SetCursorPosition(cursorLeft, cursorTop);
                    Console.Write("   ");
                    Console.SetCursorPosition(cursorLeft, cursorTop);
                }
            }

            Console.ResetColor();

            Thread.Sleep(500);

            int cursorLeftDone = Console.CursorLeft;
            int cursorTopDone = Console.CursorTop;

            Console.SetCursorPosition(cursorLeftDone - 3, cursorTopDone);
            Console.Write("   ");

            Console.SetCursorPosition(cursorLeftDone - 11, cursorTopDone);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Готово! ");
            Console.ResetColor();

            Console.WriteLine();
        }



        //Правила
        static void Rules()
        {
            Console.Clear();
            Console.WriteLine("ПРАВИЛА");
            Console.ForegroundColor = ConsoleColor.Blue;
            Thread.Sleep(300);
            Console.WriteLine("\nУ тебя есть 5 попыток чтобы угадать буквы в слове!");
            Thread.Sleep(300);
            Console.WriteLine("\nПри истечении этих попыток игра автоматически заканчивается и тебя перебрасывает на самое начало истории!");
            Thread.Sleep(300);
            Console.WriteLine("\nТы можешь использовать любую букву русского алфавита! Они будут показываться!");
            Thread.Sleep(300);
            Console.WriteLine("\nГлавное чтобы не было любых других символов!");
            Thread.Sleep(300);
            Console.WriteLine("\nНе бойся, твоё количество оставшихся попыток, а также использованные буквы будут отображены!");
            Thread.Sleep(300);
            Console.WriteLine($"\nВсего тебе нужно будет выдержать несколько битв с монстрами!");
            Thread.Sleep(300);
            Console.WriteLine("\nПосле угадывания всех слов тебя ждёт секретный босс!");
            Thread.Sleep(300);
            Console.WriteLine("\nЖелаю выстоять этот путь, добрый путник!");
            Console.ResetColor();
            Thread.Sleep(500);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();
        }



        // Игра для Мага
        static void StartMageGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА ВОЛШЕБНИКА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForMage();
        }


        // Игра для Лучника
        static void StartArcherGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА ЛУЧНИКА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForArcher();
        }


        // Игра для Рыцаря
        static void StartKnightGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА РЫЦАРЯ ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForKnight();
        }


        // Игра для Рога
        static void StartThiefGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА РАЗБОЙНИКА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForThief();
        }


        // Игра для Барда
        static void StartBardGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА БАРДА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForBard();
        }


        // Игра для Алхимика
        static void StartAlchimicGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА АЛХИМИКА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForAlchimic();
        }


        // Игра для Друида
        static void StartDruidGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА ДРУИДА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForDruid();
        }


        // Игра для Некроманта
        static void StartNecromantGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА НЕКРОМАНТА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForNecromant();
        }


        // Игра для Инженера
        static void StartуEngineerGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА ИНЖЕНЕРА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForEngineer();
        }


        // Игра для Психика
        static void StartPsychoGame()
        {
            Console.Clear();
            Console.WriteLine("=== ИГРА ЗА ПСИХИКА ===");

            Loading();

            Thread.Sleep(500);

            Rules();

            Thread.Sleep(500);

            MonstersForPsycho();
        }



        //1
        // Монстры для мага
        static void MonstersForMage()
        {
            Console.Clear();

            string[] mageMonsters =
            {
            "БИБЛИОЛИХ - живая книга-мумия",
            "ЧЕРНИЛЬНЫЙ ЭЛЕМЕНТАЛЬ - существо из чернил",
            "РУНИЧЕСКИЙ ГОЛЕМ - каменный страж с рунами",
            "ПРИЗРАК АРКАНИСТА - дух забытого мага",
            "ХРАНИТЕЛЬ СКРИЖАЛЕЙ - кристаллический защитник"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < mageMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{mageMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForMage();
        }

        //Слова для мага
        static void WordsForMage()
        {
            Console.Clear();
            List<string> mageWords = new List<string> { "РУНА", "ГРИМУАР", "ФОЛОС", "АРКАНА", "ЭФИР" };
            List<string> mageMonsters = new List<string>
            {
                "БИБЛИОЛИХ",
                "ЧЕРНИЛЬНЫЙ ЭЛЕМЕНТАЛЬ",
                "РУНИЧЕСКИЙ ГОЛЕМ",
                "ПРИЗРАК АРКАНИСТА",
                "ХРАНИТЕЛЬ СКРИЖАЛЕЙ"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (mageWords.Count > 0 && mageMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(mageMonsters.Count);
                string monster = mageMonsters[monsterIndex];

                int wordIndex = random.Next(mageWords.Count);
                string secretWord = mageWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                mageWords.Remove(secretWord);
                                mageMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {mageWords.Count} | Осталось монстров: {mageMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (mageWords.Count > 0 && mageMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (mageWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА ВОЛШЕБНИКА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("волшебник");
            }
        }


        //2
        // Монстры для лучника
        static void MonstersForArcher()
        {
            Console.Clear();

            string[] archerMonsters =
            {
                "ТЕНЕВОЙ ОЛЕНЬ - существо из лунного света и лесной мглы",
                "ПЛЕТУН - растение-хищник, сплетённое из корней и шипов",
                "КАМЕННАЯ РЫСЬ - хищник, чья шкура похожа на лесной валун",
                "ДУХ ЗАБЛУДШИХ ТРОП - призрачное существо, сбивающее с пути",
                "ЛЕСНОЙ ШЕПТУН - существо из шелеста листьев и птичьих голосов"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < archerMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{archerMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForArcher();
        }

        //Слова для лучника
        static void WordsForArcher()
        {
            Console.Clear();
            List<string> archerWords = new List<string> { "САГА", "ТРОПА", "ЛУННИК", "СТРЕЛА", "ЗВЕРИ" };
            List<string> archerMonsters = new List<string>
            {
                "ТЕНЕВОЙ ОЛЕНЬ",
                "ПЛЕТУН",
                "КАМЕННАЯ РЫСЬ",
                "ДУХ ЗАБЛУДШИХ ТРОП",
                "ЛЕСНОЙ ШЕПТУН"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (archerWords.Count > 0 && archerMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(archerMonsters.Count);
                string monster = archerMonsters[monsterIndex];

                int wordIndex = random.Next(archerWords.Count);
                string secretWord = archerWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                archerWords.Remove(secretWord);
                                archerMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {archerWords.Count} | Осталось монстров: {archerMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (archerWords.Count > 0 && archerMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (archerWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА ЛУЧНИКА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("лучник");
            }
        }


        //3
        //Монстры для рыцаря
        static void MonstersForKnight()
        {
            Console.Clear();

            string[] knightMonsters =
            {
                "ДОСПЕХ-ПРИЗРАК - пустые доспехи, движимые волей погибших рыцарей",
                "ЩИТОНОСЕЦ ЗАБВЕНИЯ - каменный гигант с щитом из мрамора",
                "КЛИНОК РАСКАЯНИЯ - одушевлённый меч, ищущий нового хозяина",
                "СТРАЖ ГЕРАЛЬДИКИ - существо из гербов и геральдических символов",
                "РЫЦАРЬ ПУСТОТЫ - воин, чьи доспехи наполнены тьмой"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < knightMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{knightMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForKnight();
        }

        //Слова для рыцаря
        static void WordsForKnight()
        {
            Console.Clear();
            List<string> knightWords = new List<string> { "ДОСПЕХ", "КЛЯТВА", "ГЕРАЛЬД", "ТУРНИР", "РЕЛИКВИЯ" };
            List<string> knightMonsters = new List<string>
            {
                "ДОСПЕХ-ПРИЗРАК",
                "ЩИТОНОСЕЦ ЗАБВЕНИЯ",
                "КЛИНОК РАСКАЯНИЯ",
                "СТРАЖ ГЕРАЛЬДИКИ",
                "РЫЦАРЬ ПУСТОТЫ"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (knightWords.Count > 0 && knightMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(knightMonsters.Count);
                string monster = knightMonsters[monsterIndex];

                int wordIndex = random.Next(knightWords.Count);
                string secretWord = knightWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                knightWords.Remove(secretWord);
                                knightMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {knightWords.Count} | Осталось монстров: {knightMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (knightWords.Count > 0 && knightMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (knightWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА РЫЦАРЯ!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("рыцарь");
            }
        }


        //4
        //Монстры для разбойника
        static void MonstersForThief()
        {
            Console.Clear();

            string[] thiefMonsters =
            {
                "КЛЮЧЕНОСЕЦ - существо из старинных ключей и замков",
                "ТЕНЬ-ПЛАГИАТОР - тень, которая копирует движения и крадёт мысли",
                "АЛИБИ-ОБОРОТЕНЬ - существо, принимающее облик последнего увидевшего его",
                "СЛЕДОХВАТ - монстр, состоящий из отпечатков и следов",
                "ШИФРОВАЛЬЩИК - существо из тайных знаков и кодов"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < thiefMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{thiefMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForThief();
        }

        //Слова для разбойника
        static void WordsForThief()
        {
            Console.Clear();
            List<string> thiefWords = new List<string> { "ТЕНЬ", "КЛЮЧ", "АЛИБИ", "СЛЕД", "ШИФР" };
            List<string> thiefMonsters = new List<string>
            {
                "КЛЮЧЕНОСЕЦ",
                "ТЕНЬ-ПЛАГИАТОР",
                "АЛИБИ-ОБОРОТЕНЬ",
                "СЛЕДОХВАТ",
                "ШИФРОВАЛЬЩИК"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (thiefWords.Count > 0 && thiefMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(thiefMonsters.Count);
                string monster = thiefMonsters[monsterIndex];

                int wordIndex = random.Next(thiefWords.Count);
                string secretWord = thiefWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                thiefWords.Remove(secretWord);
                                thiefMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {thiefWords.Count} | Осталось монстров: {thiefMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (thiefWords.Count > 0 && thiefMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (thiefWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА РАЗБОЙНИКА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("разбойник");
            }
        }


        //5
        //Монстры для барда
        static void MonstersForBard()
        {
            Console.Clear();

            string[] bardMonsters =
            {
                "ДИССОНАНС - существо из фальшивых нот и разбитых мелодий",
                "ХОР ПРИЗРАКОВ - группа призраков, поющих сводящую с ума песню",
                "ЛЮТНЯ-КРОВОСОС - оживший инструмент с струнами-щупальцами",
                "СКАЗИТЕЛЬ БЕЗМОЛВИЯ - монстр, крадущий голоса и слова",
                "РИТМ-ГОЛЕМ - существо, созданное из барабанного боя и такта"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < bardMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{bardMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForBard();
        }

        //Слова для барда
        static void WordsForBard()
        {
            Console.Clear();
            List<string> bardWords = new List<string> { "БАЛЛАДА", "ЛЮТНЯ", "СКАЗ", "МОТИВ", "ЭПОС" };
            List<string> bardMonsters = new List<string>
            {
                "ДИССОНАНС",
                "ХОР ПРИЗРАКОВ",
                "ЛЮТНЯ-КРОВОСОС",
                "СКАЗИТЕЛЬ БЕЗМОЛВИЯ",
                "РИТМ-ГОЛЕМ"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (bardWords.Count > 0 && bardMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(bardMonsters.Count);
                string monster = bardMonsters[monsterIndex];

                int wordIndex = random.Next(bardWords.Count);
                string secretWord = bardWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                bardWords.Remove(secretWord);
                                bardMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {bardWords.Count} | Осталось монстров: {bardMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (bardWords.Count > 0 && bardMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (bardWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА БАРДА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("бард");
            }
        }


        //6
        //Монстры для алхимика
        static void MonstersForAlchimic()
        {
            Console.Clear();

            string[] alchimicMonsters =
            {
                "ЖИДКИЙ ГОЛЕМ - существо из ртути и философского камня",
                "ПЛАМЕННЫЙ ДИСТИЛЛЯТОР - оживший аппарат с огненным сердцем",
                "КРИСТАЛЛО-ХИМИК - кристаллическое существо, растущее от реакций",
                "ТОКСИЧНЫЙ ПАР - облако ядовитых испарений с сознанием",
                "ГЕНОМНЫЙ ВАРЬОР - мутант, созданный запретными зельями"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < alchimicMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{alchimicMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForAlchimic();
        }

        //Слова для алхимика
        static void WordsForAlchimic()
        {
            Console.Clear();
            List<string> alchimicWords = new List<string> { "РЕАГЕНТ", "ТИГЕЛЬ", "ЭЛИКСИР", "ТРАНСМУТАЦИЯ", "КАТАЛИЗАТОР" };
            List<string> alchimicMonsters = new List<string>
            {
                "ЖИДКИЙ ГОЛЕМ",
                "ПЛАМЕННЫЙ ДИСТИЛЛЯТОР",
                "КРИСТАЛЛО-ХИМИК",
                "ТОКСИЧНЫЙ ПАР",
                "ГЕНОМНЫЙ ВАРЬОР"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (alchimicWords.Count > 0 && alchimicMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(alchimicMonsters.Count);
                string monster = alchimicMonsters[monsterIndex];

                int wordIndex = random.Next(alchimicWords.Count);
                string secretWord = alchimicWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                alchimicWords.Remove(secretWord);
                                alchimicMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {alchimicWords.Count} | Осталось монстров: {alchimicMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (alchimicWords.Count > 0 && alchimicMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (alchimicWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА АЛХИМИКА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("алхимик");
            }
        }


        //7
        //Монстры для друида
        static void MonstersForDruid()
        {
            Console.Clear();

            string[] druidMonsters =
            {
                "ОСКВЕРНИТЕЛЬ РОЩИ - тварь, питающаяся жизненной силой деревьев",
                "МУТИРОВАВШИЙ МИКОРИЗ - грибница с разумом и щупальцами",
                "ГНЕВНЫЙ ЭНТ - древнее дерево, пробудившееся для мести",
                "ВЕТРОГОН - существо из урагана и осенних листьев",
                "КАМЕННЫЙ САМОРОДОК - оживший минерал с кристаллической структурой"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < druidMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{druidMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForDruid();
        }

        //Слова для друида
        static void WordsForDruid()
        {
            Console.Clear();
            List<string> druidWords = new List<string> { "ЖРЕЦ", "ФИТОНИЯ", "ТОТЕМ", "СЕЗОН", "ГАРМОНИЯ" };
            List<string> druidMonsters = new List<string>
            {
                "ОСКВЕРНИТЕЛЬ РОЩИ",
                "МУТИРОВАВШИЙ МИКОРИЗ",
                "ГНЕВНЫЙ ЭНТ",
                "ВЕТРОГОН",
                "КАМЕННЫЙ САМОРОДОК"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (druidWords.Count > 0 && druidMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(druidMonsters.Count);
                string monster = druidMonsters[monsterIndex];

                int wordIndex = random.Next(druidWords.Count);
                string secretWord = druidWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                druidWords.Remove(secretWord);
                                druidMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {druidWords.Count} | Осталось монстров: {druidMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (druidWords.Count > 0 && druidMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (druidWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА ДРУИДА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("друид");
            }
        }


        //8
        //Монстры для некроманта
        static void MonstersForNecromant()
        {
            Console.Clear();

            string[] necromantMonsters =
            {
                "СКЕЛЕТ-ЛЕТОПИСЕЦ - костяной монстр со свитками из кожи",
                "ПРИЗРАЧНЫЙ СКРИБА - дух, пишущий проклятия невидимыми чернилами",
                "ГРОБНИЧНЫЙ ЧЕРВЬ - паразит, питающийся магией смерти",
                "ТЕНЬ ЗАБВЕНИЯ - существо, стирающее память и имена",
                "КОСТЯНОЙ КАТАФАЛК - передвижная гробница с щупальцами из рёбер"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < necromantMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{necromantMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForNecromant();
        }

        //Слова для некроманта
        static void WordsForNecromant()
        {
            Console.Clear();
            List<string> necromantWords = new List<string> { "ЛИЧ", "РЕКВИЕМ", "САРКОФАГ", "ЭКТОПЛАЗМА", "ОБИТЕЛЬ" };
            List<string> necromantMonsters = new List<string>
            {
                "СКЕЛЕТ-ЛЕТОПИСЕЦ",
                "ПРИЗРАЧНЫЙ СКРИБА",
                "ГРОБНИЧНЫЙ ЧЕРВЬ",
                "ТЕНЬ ЗАБВЕНИЯ",
                "КОСТЯНОЙ КАТАФАЛК"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (necromantWords.Count > 0 && necromantMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(necromantMonsters.Count);
                string monster = necromantMonsters[monsterIndex];

                int wordIndex = random.Next(necromantWords.Count);
                string secretWord = necromantWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                necromantWords.Remove(secretWord);
                                necromantMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {necromantWords.Count} | Осталось монстров: {necromantMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (necromantWords.Count > 0 && necromantMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (necromantWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА НЕКРОМАНТА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("некромант");
            }
        }


        //9
        //Монстры для инженера
        static void MonstersForEngineer()
        {
            Console.Clear();

            string[] enginnerMonsters =
            {
                "БЕЗУМНЫЙ АВТОМАТОН - механизм, вышедший из-под контроля",
                "РЖАВЫЙ ГОЛЕМ - существо из металлолома и шестерёнок",
                "ПАРОВОЙ ЛЕВИАФАН - гигантская машина на паровом ходу",
                "ТИК-ТАК ТЕРМИНАТОР - часовой механизм с бритвенными лезвиями",
                "ДИНАМО-ЭЛЕМЕНТАЛЬ - существо из чистой электрической энергии"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < enginnerMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{enginnerMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForEngineer();
        }

        //Слова для инженера
        static void WordsForEngineer()
        {
            Console.Clear();
            List<string> engineerWords = new List<string> { "ШЕСТЕРНЯ", "ПАРОВОЗ", "КОНСТРУКЦИЯ", "ИЗОБРЕТЕНИЕ", "МЕХАНИЗМ" };
            List<string> engineerMonsters = new List<string>
            {
                "БЕЗУМНЫЙ АВТОМАТОН",
                "РЖАВЫЙ ГОЛЕМ",
                "ПАРОВОЙ ЛЕВИАФАН",
                "ТИК-ТАК ТЕРМИНАТОР",
                "ДИНАМО-ЭЛЕМЕНТАЛЬ"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (engineerWords.Count > 0 && engineerMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(engineerMonsters.Count);
                string monster = engineerMonsters[monsterIndex];

                int wordIndex = random.Next(engineerWords.Count);
                string secretWord = engineerWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                engineerWords.Remove(secretWord);
                                engineerMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {engineerWords.Count} | Осталось монстров: {engineerMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (engineerWords.Count > 0 && engineerMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (engineerWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА ИНЖЕНЕРА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("инженер");
            }
        }


        //10
        //Монстры для психика
        static void MonstersForPsycho()
        {
            Console.Clear();

            string[] psychoMonsters =
            {
                "КОШМАРНЫЙ ПРОЕКТОР - существо, материализующее страхи",
                "МИМИК-ЭМОЦИЯ - тварь, питающаяся чувствами и мыслями",
                "ПСИХИЧЕСКИЙ ПАРАЗИТ - сущность, живущая в чужих сознаниях",
                "ЗЕРКАЛЬНЫЙ ДВОЙНИК - отражение, обретшее самостоятельность",
                "ШЕПТУН БЕЗМОЛВИЯ - существо, крадущее внутренний голос"
            };

            Console.WriteLine("Вы начинаете своё путешествие!");
            Console.WriteLine("\nНа вашем пути вам могут попасться следующие монстры:");

            for (int i = 0; i < psychoMonsters.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Thread.Sleep(500);
                Console.WriteLine($"\n{psychoMonsters[i]}");
            }
            Console.ResetColor();

            Thread.Sleep(1000);
            Console.WriteLine("\nСможете ли вы их одолеть?");
            Thread.Sleep(300);
            Console.WriteLine("\nНажмите любую клавишу для продолжения истории...");
            Console.ReadKey();

            WordsForPsycho();
        }

        //Слова для психика
        static void WordsForPsycho()
        {
            Console.Clear();
            List<string> psychoWords = new List<string> { "ТЕЛЕПАТ", "ИЛЛЮЗИЯ", "ПОДСОЗНАНИЕ", "МЕДИТАЦИЯ", "ПСИХОЗ" };
            List<string> psychoMonsters = new List<string>
            {
                "КОШМАРНЫЙ ПРОЕКТОР",
                "МИМИК-ЭМОЦИЯ",
                "ПСИХИЧЕСКИЙ ПАРАЗИТ",
                "ЗЕРКАЛЬНЫЙ ДВОЙНИК",
                "ШЕПТУН БЕЗМОЛВИЯ"
            };

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            Random random = new Random();

            while (psychoWords.Count > 0 && psychoMonsters.Count > 0)
            {
                Console.Clear();

                int monsterIndex = random.Next(psychoMonsters.Count);
                string monster = psychoMonsters[monsterIndex];

                int wordIndex = random.Next(psychoWords.Count);
                string secretWord = psychoWords[wordIndex];

                char[] displayWord = new char[secretWord.Length];
                for (int i = 0; i < secretWord.Length; i++)
                {
                    displayWord[i] = '_';
                }

                int attemptsLeft = 5;
                List<char> usedLetters = new List<char>();

                bool wordGuessed = false;
                while (attemptsLeft > 0 && !wordGuessed)
                {
                    Console.Clear();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Вам попался {monster} и он загадал слово!");
                    Console.ResetColor();
                    Console.WriteLine("\nСможете ли вы его отгадать?");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nЗагаданное слово: {string.Join(" ", displayWord)}");
                    Console.WriteLine($"Осталось попыток: {attemptsLeft}/5");
                    Console.ResetColor();

                    if (usedLetters.Count > 0)
                    {
                        Console.Write("\nИспользованные буквы: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        foreach (char let in usedLetters)
                        {
                            Console.Write($"{let} ");
                        }
                        Console.ResetColor();
                    }

                    Console.WriteLine("\n\nБуквы, которые можно использовать!");
                    Console.WriteLine();

                    for (int i = 0; i < russianLowercase.Count; i++)
                    {
                        Console.Write($"{russianLowercase[i]} ");
                    }

                    Console.WriteLine("\n\nВведите букву: ");
                    string input = Console.ReadLine();

                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Вы ничего не ввели!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    if (input.Length > 1)
                    {
                        Console.WriteLine("Введите только одну букву!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    char letter = char.ToUpper(input[0]);

                    if (russianLowercase.Contains(char.ToLower(letter)))
                    {
                        if (usedLetters.Contains(letter))
                        {
                            Console.WriteLine($"Буква '{letter}' уже была!");
                            Thread.Sleep(1000);
                            continue;
                        }

                        usedLetters.Add(letter);

                        if (secretWord.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nТак держать! Вы нанесли ему урон!");
                            Console.ResetColor();

                            for (int i = 0; i < secretWord.Length; i++)
                            {
                                if (secretWord[i] == letter)
                                {
                                    displayWord[i] = letter;
                                }
                            }

                            if (new string(displayWord) == secretWord)
                            {
                                wordGuessed = true;
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nПОБЕДА!");
                                Thread.Sleep(700);
                                Console.WriteLine($"\nВы отгадали слово: {secretWord}");
                                Console.WriteLine($"\n{monster} повержен!");

                                psychoWords.Remove(secretWord);
                                psychoMonsters.Remove(monster);

                                Console.WriteLine($"\nОсталось слов: {psychoWords.Count} | Осталось монстров: {psychoMonsters.Count}");
                                Console.ResetColor();

                                Thread.Sleep(1500);

                                if (psychoWords.Count > 0 && psychoMonsters.Count > 0)
                                {
                                    Console.WriteLine("\nПереходим к следующему противнику...");
                                    Thread.Sleep(1500);
                                }
                                break;
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nО нет! Он нанёс вам урон (-1 попытка)!");
                            attemptsLeft--;
                            Console.ResetColor();

                            if (attemptsLeft == 0)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Thread.Sleep(700);
                                Console.WriteLine($"\nПОРАЖЕНИЕ!");
                                Console.WriteLine($"\n{monster} победил!");
                                Console.WriteLine($"\nЗагаданное слово было: {secretWord}");
                                Console.ResetColor();
                                Thread.Sleep(2000);

                                ChooseCharacterClass();
                                return;
                            }
                        }

                        Thread.Sleep(500);

                        if (attemptsLeft > 0 && !wordGuessed)
                        {
                            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                        Thread.Sleep(1000);
                    }
                }
            }

            Console.Clear();

            if (psychoWords.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.WriteLine("ВЫ ОСВОБОДИЛИ ВСЕ СЛОВА ПСИХИКА!");
                Console.WriteLine("Все монстры были повержены!");
                Console.WriteLine("\n═══════════════════════════════════════");
                Console.ResetColor();

                Thread.Sleep(2500);
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("ОСТОРОЖНО! ВПЕРЕДИ ВАС ОЖИДАЕТ БОСС!");
                Console.ResetColor();
                Thread.Sleep(2000);

                FinalBossBattle("психик");
            }
        }



        //Финальный босс
        static void FinalBossBattle(string className)
        {
            string bossName;
            string bossWord;

            switch (className)
            {
                case "волшебник":
                    bossName = "АРХИМАГ БЕЗДНЫ";
                    bossWord = "ИНКАНТАЦИЯ";
                    break;
                case "лучник":
                    bossName = "КОРОЛЬ ДРЕВНЕГО ЛЕСА";
                    bossWord = "ДОЛГОЛЕТИЕ";
                    break;
                case "рыцарь":
                    bossName = "ТЁМНЫЙ ПАЛЛАДИН";
                    bossWord = "БЛАГОРОДСТВО";
                    break;
                case "разбойник":
                    bossName = "КОРОЛЬ ТЕНЕЙ";
                    bossWord = "КОНСПИРАЦИЯ";
                    break;
                case "бард":
                    bossName = "МАЭСТРО БЕЗМОЛВИЯ";
                    bossWord = "МНОГОГОЛОСИЕ";
                    break;
                case "алхимик":
                    bossName = "ГРААЛЬНЫЙ АЛХИМИК";
                    bossWord = "КВИНТЭССЕНЦИЯ ";
                    break;
                case "друид":
                    bossName = "ПЕРВОРОДНЫЙ ЭНТ";
                    bossWord = "СИМБИОЗ";
                    break;
                case "некромант":
                    bossName = "ЛИЧ-ПАТРИАРХ";
                    bossWord = "РЕАНИМАЦИЯ";
                    break;
                case "инженер":
                    bossName = "МЕХАНОЛОРД";
                    bossWord = "ИННОВАЦИЯ";
                    break;
                case "психик":
                    bossName = "ПСИХЕЙ-ПОГЛОТИТЕЛЬ";
                    bossWord = "ТЕЛЕКИНЕЗ";
                    break;
                default:
                    bossName = "%#$^*";
                    bossWord = "(@!>/";
                    Console.Clear();
                    Console.WriteLine("оШиБкА! Вы БуДеТе ЭкСтРеНнО пЕрЕнАпРаВлЕнЫ нА сТаРт!");
                    Thread.Sleep(2000);
                    StartGame();
                    return;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("═════════════════════════════════════════");
            Console.WriteLine($" ФИНАЛЬНЫЙ БОСС: {bossName}!");
            Console.WriteLine("═════════════════════════════════════════");
            Console.ResetColor();
            Thread.Sleep(1000);

            Console.WriteLine($"\n{bossName} попался вам на пути!");
            Console.WriteLine("\nОн вызывает вас на последний бой!");
            Console.WriteLine($"\nОн загадал особенное слово!");
            Console.WriteLine("\nУ вас есть только 3 попытки!");
            Thread.Sleep(5000);

            PlayBossGame(bossWord, bossName, className);
        }


        //Сражение с боссом
        static void PlayBossGame(string bossWord, string bossName, string className)
        {
            char[] displayWord = new char[bossWord.Length];
            for (int i = 0; i < displayWord.Length; i++)
            {
                displayWord[i] = '_';
            }

            int attempts = 3;
            List<char> usedLetters = new List<char>();

            List<char> russianLowercase = new List<char> {
                'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м',
                'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ',
                'ы', 'ь', 'э', 'ю', 'я'
            };

            bool wordGuessed = false;
            while (attempts > 0 && !wordGuessed)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"═══════════════════════════════════════");
                Console.WriteLine($" БИТВА С {bossName}");
                Console.WriteLine($"═══════════════════════════════════════");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nСлово босса: {string.Join(" ", displayWord)}");
                Console.WriteLine($"\nПопыток: {attempts}/3 ");
                Console.ResetColor();

                if (usedLetters.Count > 0)
                {
                    Console.Write("\nИспользованные буквы: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    foreach (char let in usedLetters)
                    {
                        Console.Write($"{let} ");
                    }
                    Console.ResetColor();
                }

                Console.WriteLine("\n\nБуквы, которые можно использовать!");
                Console.WriteLine();

                for (int i = 0; i < russianLowercase.Count; i++)
                {
                    Console.Write($"{russianLowercase[i]} ");
                }

                Console.WriteLine("\n\nВведите букву: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Вы ничего не ввели!");
                    Thread.Sleep(1000);
                    continue;
                }

                if (input.Length > 1)
                {
                    Console.WriteLine("Введите только одну букву!");
                    Thread.Sleep(1000);
                    continue;
                }

                char letter = char.ToUpper(input[0]);

                if (russianLowercase.Contains(char.ToLower(letter)))
                {
                    if (usedLetters.Contains(letter))
                    {
                        Console.WriteLine($"Буква '{letter}' уже была!");
                        Thread.Sleep(1000);
                        continue;
                    }

                    usedLetters.Add(letter);

                    if (bossWord.Contains(letter))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nОтличный удар!");

                        for (int i = 0; i < bossWord.Length; i++)
                        {
                            if (bossWord[i] == letter)
                            {
                                displayWord[i] = letter;
                            }
                        }

                        Console.ResetColor();

                        if (new string(displayWord) == bossWord)
                        {
                            wordGuessed = true;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"\n════════════════════════════════════════════════════");
                            Console.WriteLine($"           ПОБЕДА НАД БОССОМ!");
                            Console.WriteLine($"════════════════════════════════════════════════════");
                            Console.WriteLine($"\nВы отгадали слово: {bossWord}");
                            Console.WriteLine($"\nВы победили {bossName}!");
                            Console.WriteLine($"\nВы освободили абсолютно все слова персонажа: {className.ToUpper()}!");
                            Console.ResetColor();

                            Thread.Sleep(2500);
                            break;
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nКритический урон!");
                        attempts--;
                        Console.ResetColor();

                        if (attempts == 0)
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\n═══════════════════════════════════════");
                            Console.WriteLine($"         ПОРАЖЕНИЕ ОТ БОССА");
                            Console.WriteLine($"═══════════════════════════════════════");
                            Console.WriteLine($"\n{bossName} победил вас!");
                            Console.WriteLine($"Слово босса было: {bossWord}");
                            Console.ResetColor();

                            Thread.Sleep(2000);
                            ChooseCharacterClass();
                            return;
                        }
                    }

                    Thread.Sleep(500);

                    if (attempts > 0 && !wordGuessed)
                    {
                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("\nОшибка ввода! Введите русскую букву.");
                    Thread.Sleep(1000);
                }
            }

            // Победа над боссом
            if (wordGuessed)
            {
                Console.WriteLine("\nНажмите любую клавишу, чтобы вернуться в выбор класса...");
                Console.ReadKey();
                ChooseCharacterClass();
            }
        }


        // Выход из игры
        static void ExitGame()
        {
            Console.Clear();
            Console.WriteLine("Не буду держать тебя, добрый путник, прощай!");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }

        // Обработка некорректного ввода
        static void HandleInvalidInput()
        {
            Console.Clear();
            Console.WriteLine("Я не понимаю твоего ответа, давай попробуем ещё раз!");
            Thread.Sleep(2000);
            StartGame();
        }
    }
}