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


        public Player (string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }

        public Player (char symbol) : this ("AI",symbol)
        {
            aiPlayer = true;
            ai = new ArtificialIntelligence();
        }


        public void Move((int x, int y) position, ref Field gameField)
        {
            gameField.WriteSymbol(position.x, position.y, Symbol);
        }

        public void AIMove(ref Field gameField)
        {
            
        }
    }
}
