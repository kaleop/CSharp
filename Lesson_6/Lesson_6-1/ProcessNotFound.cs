using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6_1
{
    enum Teg
    {
        Name, ID
    }

    [Serializable]
    class ProcessNotFound : Exception
    {
        public Teg Code { get; }
        public ProcessNotFound (Teg t)
        {
            Code = t;
        }
    }
}
