using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysing_Log_data
{
    class State : IState
    {
        private string _name;
        private bool _isFinale;
      
        public State(string name, bool isFinal)
        {
            _name = name;
            _isFinale = isFinal;
        }
        public bool isFinal()
        {
            return _isFinale;
        }

        public string name()
        {
            return _name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
