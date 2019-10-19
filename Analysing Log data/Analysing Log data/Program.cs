using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysing_Log_data
{
    class Program
    {
        static void Main(string[] args)
        {
            //Alphabet alphabet = new Alphabet("login options create");
            //Automaton automaton = new Automaton(alphabet);
            //automaton.start();

            Alphabet alphabet = new Alphabet("login home create");
            Automaton automaton = new Automaton(alphabet);
            automaton.start();

            Console.ReadLine();
        }
    }
}
