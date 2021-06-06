using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    enum ExceptionTeg
    {
        ErrorArrayLength,
        ErrorWinRangeLength,
        ErrorOutOfRange,
    }

    [Serializable]
    class GameException :Exception
    {
        public ExceptionTeg Mark { get; private set; }
        public GameException(ExceptionTeg ex)
        {
            Mark = ex;
        }
    }
}
