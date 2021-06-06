using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    
     class Game
    {
        private string outOfRange = "Введённое значение не входит в заданный диапазон";
        private string errorValue = "Введено не корректное значение!";
        private (int x, int y) step;
        public Player User { get; private set; }
        public Player AI { get; private set; }
        private Field gameField;
        public Field GameField
        { 
            get
            {
                return gameField;
            }
            private set
            {
                gameField = value;
            }
        }

        public Game()
        {            
            User = new Player(Environment.UserName, 'X');
            AI = new Player('O');
        }

        public  void Start()
        {
            GetArraySize();
            Console.WriteLine();
            GetWinRange();
            Show();
        }

        public void Play()
        {
            GetPosition();
            User.Move(step, ref gameField);
            Show();
            AI.AIMove();
            Show();

        }

        private void Show()
        {
            Console.Clear();
            GameField.ShowField();
        }

        private void GetArraySize ()
        {
            Console.WriteLine("Введите размер поля от 3 до 7 :");
            try
            {
                GameField = new Field(Int32.Parse(Console.ReadLine()));
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

        private void Warning (string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n{s}\n");
            Console.ResetColor();
        }

        private void GetWinRange ()
        {
            if (GameField.FieldSize != 3)
            {
                Console.WriteLine($"Введите кол-во символов в ряд до выигрыша от {3} до {GameField.FieldSize}");
                try
                {
                    GameField.WinRage = Int32.Parse(Console.ReadLine());
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
            if ((x - 1) >= 0 && x <= GameField.FieldSize)
            {
                return x;
            }
            throw new GameException(ExceptionTeg.ErrorOutOfRange);
        }

        private bool CheckPosition(int x, int y)
        {
            return GameField.GameField[y-1, x-1] == '-';
        }
    }
}
