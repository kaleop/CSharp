using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    class ArtificialIntelligence
    {
        private List<(int x, int y)> userPosition = new List<(int x, int y)>();
        private List<char[]> userLines;
        private List<char[]> userPotentialWinLines;
        private Field playField;

        public ArtificialIntelligence(ref Field playField)
        {
            this.playField = playField;
            userLines = new List<char[]>();
            userPotentialWinLines = new List<char[]>();
        }

        public void Analysis ()
        {
        }

        private List<(int x, int y)> GetUserPositions()
        {
            List<(int x, int y)> up = new List<(int x, int y)>();
            for (int i = 0; i < playField.FieldSize; i++)
            {
                for (int j = 0; j < playField.FieldSize; j++)
                {
                    if (playField.GameField[i, j] == 'X')
                    {
                        up.Add((j, i));
                    }
                }
            }
            return up;
        }

        private void CheckUserPosition((int x, int y) up)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < playField.FieldSize; i++)
            {
                sb.Append(playField.GameField[i, up.y]);
            }
        }
    }
}
