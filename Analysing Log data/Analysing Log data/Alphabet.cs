using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysing_Log_data
{
    class Alphabet : IAlphabet
    {
        private List<string> _aplhabet;
        private string _inputs;
        public Alphabet(string inputs)  //e.g. "A B C"
        {
            _aplhabet = new List<string>();
            _inputs = inputs;
            createList();
        }

        private void createList()
        {
            string[] splitList = _inputs.Split(' ');
            foreach (var item in splitList)
            {
                _aplhabet.Add(item);
            }
        }

        public List<string> getAlphabet()
        {
            return _aplhabet;
        }

        public int size()
        {
            return _aplhabet.Count();
        }
    }
}
