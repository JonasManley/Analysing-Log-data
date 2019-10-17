using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysing_Log_data
{
    interface IAlphabet
    {
        List<string> getAlphabet();
        int size();
    }
}
