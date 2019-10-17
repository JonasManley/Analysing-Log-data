using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysing_Log_data
{
    interface IState
    {
            string name();

            // Depending on impl.
            bool isFinal();
    }
}
