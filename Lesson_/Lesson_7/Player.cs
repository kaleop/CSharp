using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class Player
    {
        public string Name { get; private set; }
        public char Symbol { get; private set; }
        private bool aiPlayer = false;
        private ArtificialIntelligence ai;
        private Field playField;


        public Player (string name, char symbol, ref Field playField)
        {
            Name = name;
            Symbol = symbol;
            this.playField = playField;
        }

        public Player (char symbol, ref Field playField) : this ("AI",symbol, ref playField)
        {
            aiPlayer = true;
            ai = new ArtificialIntelligence( ref playField);
        }


        public void Move((int x, int y) position, ref Field gameField)
        {
            gameField.WriteSymbol(position.x, position.y, Symbol);
        }

        public void AIMove()
        {
            Random r = new Random();
            try
            {
                playField.WriteSymbol(r.Next(1, 7), r.Next(1, 7), Symbol);
            }
            catch (GameException ex) when (ex.Mark == ExceptionTeg.ErrorCellIsClosed)
            {
                AIMove();
            }
        }
    }
}
