using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Field
    {
        private char[,] field;
        public Char[,] GameField
        {
            get
            {
                return field;
            }
        }

        private int fieldSize = 3;
        public int FieldSize 
        { 
            get
            {
                return fieldSize;
            }
            private set
            {
                if (value >2 && value <8)
                {
                    fieldSize = value;
                }
                else
                {

                    throw new GameException(ExceptionTeg.ErrorArrayLength);
                }
            }
        }

        private int winRange = 3;
        public int WinRange
        {
            get 
            {
                return winRange;
            }
            set
            {
                if (value > 2 && value <= FieldSize)
                {
                    winRange = value;
                }
                else
                {
                    throw new GameException(ExceptionTeg.ErrorWinRangeLength);
                }
            }
        }


        public Field(int fieldSize)
        {
            FieldSize = fieldSize;
            field = FieldGenerate();
        }


        private char[,] FieldGenerate ()
        {
            char[,] field = new char[FieldSize, FieldSize];
            for (int i = 0; i < FieldSize; i++)
            {
                for (int j = 0; j < FieldSize; j++)
                {
                    field[i, j] = '-';
                }
            }
            return field;
        }

        public void ShowField ()
        {
            for (int i = 0; i < FieldSize; i++)
            {
                for (int j = 0; j < FieldSize; j++)
                {
                    Console.Write(field[i, j]);
                }
                Console.WriteLine();
            }
        }

        public void WriteSymbol(int x, int y, char c)
        {
            field[y-1, x-1] = c;
        }
    }
}
