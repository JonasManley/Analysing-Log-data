using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysing_Log_data
{
    interface IAutomaton
    {
        string getAlphabet(); //{A C D}

        string getInitialState();

        State nextState(int index);
        
        void start();
    }
}
