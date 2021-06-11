using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    enum Status
    {
        WinPlayer,
        WinAI,
        DrawGame,
        Nothing
    }
     class Game
    {
        private string outOfRange = "Введённое значение не входит в заданный диапазон";
        private string errorValue = "Введено не корректное значение!";
        private string cellisClossed = "Ячейка занята";

        private string userWinString;
        private string aiWinString;
        private Status gameStatus;

        private List<string> allLine;

        private (int x, int y) step;
        public Player User { get; private set; }
        public Player AI { get; private set; }
        private Field playingField;
        public Field PlayingField
        { 
            get
            {
                return playingField;
            }
            private set
            {
                playingField = value;
            }
        }

        public Game()
        {            
            gameStatus = Status.Nothing;
            allLine = new List<string>();
        }

        public  void Start()
        {
            GetArraySize();
            User = new Player(Environment.UserName, 'X', ref playingField);
            AI = new Player('O', ref  playingField);
            userWinString = new string('X', PlayingField.WinRange);
            aiWinString = new string('O', PlayingField.WinRange);
            Console.WriteLine();
            GetWinRange();
            Show();
        }

        public void Play()
        {
            Status s = new Status();
            GetPosition();
            Console.Clear();
            User.Move(step, ref playingField);
            s = Scan();
            AI.AIMove();
            s = Scan();
            Show();

            switch (s)
            {
                case Status.WinPlayer:
                    Warning($"{User.Name} Победил", ConsoleColor.Green);
                    break;
                case Status.WinAI:
                    Warning($"{AI.Name} победил");
                    break;
                case Status.DrawGame:
                    Warning("Ничья", ConsoleColor.Yellow);
                    break;
                case Status.Nothing:
                    Play();
                    break;
            }

        }

        private void Show()
        {
            Console.Clear();
            PlayingField.ShowField();
        }

        private void GetArraySize ()
        {
            Console.WriteLine("Введите размер поля от 3 до 7 :");
            try
            {
                PlayingField = new Field(Int32.Parse(Console.ReadLine()));
            }
            catch (GameException ex) when (ex.Mark == ExceptionTeg.ErrorArrayLength)
            {
                Warning(outOfRange);
                GetArraySize();
            }
            catch (Exception)
            {
                Warning(errorValue);
                GetArraySize();
            }
        }

        public void Warning (string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{s}\n");
            Console.ResetColor();
        }

        public void Warning(string s, ConsoleColor cs)
        {
            Console.ForegroundColor = cs;
            Console.WriteLine($"\n{s}\n");
            Console.ResetColor();
        }

        private void GetWinRange ()
        {
            if (PlayingField.FieldSize != 3)
            {
                Console.WriteLine($"Введите кол-во символов в ряд до выигрыша от {3} до {PlayingField.FieldSize}");
                try
                {
                    PlayingField.WinRange = Int32.Parse(Console.ReadLine());
                }
                catch (GameException ex) when (ex.Mark == ExceptionTeg.ErrorWinRangeLength)
                {
                    Warning(outOfRange);
                    GetWinRange();
                }
                catch (Exception)
                {
                    Warning(errorValue);
                    GetWinRange();
                }
            }
        }

        private void GetPosition ()
        {
            string s;
            (int x, int y) pos;
            try
            {
                Console.WriteLine("Введите координату X");
                s = Console.ReadLine();
                pos.x = GetValue(s);
                Console.WriteLine("Введите координату Y");
                s = Console.ReadLine();
                pos.y = GetValue(s);

                if(CheckPosition(pos.x, pos.y))
                {
                    step = pos;
                }
                else
                {
                    Warning(cellisClossed);
                    GetPosition();
                }
            }
            catch (GameException ex) when (ex.Mark == ExceptionTeg.ErrorOutOfRange)
            {
                Warning(outOfRange);
                GetPosition();
            }
            catch(Exception)
            {
                Warning(errorValue);
                GetPosition();
            }
        }

        private int GetValue (string s)
        {
            int x = Int32.Parse(s);
            if ((x - 1) >= 0 && x <= PlayingField.FieldSize)
            {
                return x;
            }
            throw new GameException(ExceptionTeg.ErrorOutOfRange);
        }

        private bool CheckPosition(int x, int y)
        {
            return PlayingField.GameField[y-1, x-1] == '-';
        }

        private Status Scan()
        {
            GetAllLine();
            foreach (string s in allLine)
            {
                if (s.Contains( new string('X', PlayingField.WinRange)))
                {
                    return Status.WinPlayer;
                }
                if (s.Contains(new string('O', PlayingField.WinRange)))
                {
                    return Status.WinAI;
                }
            }

            int allClosed = 0;
            foreach (char c in PlayingField.GameField)
            {
                if (c != '-')
                {
                    allClosed++;
                }
                else return Status.Nothing;
            }
            if (allClosed == PlayingField.FieldSize*PlayingField.FieldSize )
            {
                return Status.DrawGame;
            }
            return Status.Nothing;
        }

        private List<string> GetHorizontLine()
        {
            StringBuilder sbHorizont = new StringBuilder();

            List<string> line = new List<string>();

            for (int i = 0; i < PlayingField.FieldSize; i++)
            {
                for (int j = 0; j < PlayingField.FieldSize; j++)
                {
                    sbHorizont.Append(PlayingField.GameField[i, j]);
                    if (j + 1 == PlayingField.FieldSize)
                    {
                        line.Add(sbHorizont.ToString());
                        sbHorizont.Clear();
                    }
                }
            }
            return line;
        }

        private List<string> GetVerticalLine ()
        {
            StringBuilder sbVertical = new StringBuilder();

            List<string> line = new List<string>();

            for (int i = 0; i < PlayingField.FieldSize; i++)
            {
                for (int j = 0; j < PlayingField.FieldSize; j++)
                {
                    sbVertical.Append(PlayingField.GameField[j, i]);
                    if (j + 1 == PlayingField.FieldSize)
                    {
                        line.Add(sbVertical.ToString());
                        sbVertical.Clear();
                    }

                }
            }
            return line;
        }

        private List<string> GetDiagonals()
        {
            List<string> line = new List<string>();
            StringBuilder sbDiag = new StringBuilder();

            int counter = 0;
            do
            {
                for (int i = 0; i < PlayingField.FieldSize; i++)
                {
                    sbDiag.Append(PlayingField.GameField[i, i + counter]);
                    if (i == PlayingField.FieldSize - 1-counter)
                    {
                        line.Add(sbDiag.ToString());
                        counter++;
                        sbDiag.Clear();
                        break;
                    }
                }
            }
            while (counter < PlayingField.WinRange);


            counter = 1;
            do
            {
                for (int i = counter; i < PlayingField.FieldSize; i++)
                {
                    sbDiag.Append(PlayingField.GameField[i, i - counter]);
                    if (i == PlayingField.FieldSize - 1)
                    {
                        line.Add(sbDiag.ToString());
                        counter++;
                        sbDiag.Clear();
                        break;
                    }
                }
            }
            while (counter < PlayingField.WinRange);

            counter = 0;
            do
            {
                for (int i = 0; i < PlayingField.FieldSize; i++)
                {
                    sbDiag.Append(PlayingField.GameField[i, PlayingField.FieldSize - 1 - i-counter]);
                    if (i == PlayingField.FieldSize - 1-counter)
                    {
                        line.Add(sbDiag.ToString());
                        counter++;
                        sbDiag.Clear();
                        break;
                    }
                }
            }
            while (counter < PlayingField.WinRange);

            counter = 0;
            do
            {
                for (int i = 1; i < PlayingField.FieldSize; i++)
                {
                    sbDiag.Append(PlayingField.GameField[i+counter, PlayingField.FieldSize - i]);
                    if (i == PlayingField.FieldSize - 1-counter)
                    {
                        line.Add(sbDiag.ToString());
                        counter++;
                        sbDiag.Clear();
                        break;
                    }
                }
            }
            while (counter < PlayingField.WinRange-1);

            return line;
        }

        private void GetAllLine ()
        {
            allLine.AddRange(GetHorizontLine());
            allLine.AddRange(GetVerticalLine());
            allLine.AddRange(GetDiagonals());
        }

        private void ShowLines()
        {
            foreach(string s in allLine)
            {
                Console.WriteLine(s);
            }
        }
    }
}
