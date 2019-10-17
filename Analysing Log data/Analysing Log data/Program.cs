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
            State stateLogin = new State("login", false);
            State stateOption = new State("options", false);
            State stateLogout = new State("logout", false);
            State stateCreate = new State("create", true);

            Alphabet alphabet = new Alphabet("login options create");
            //foreach (var item in alphabet.getAlphabet())
            //{
            //    Console.WriteLine(item);
            //}

            Automaton automaton = new Automaton(alphabet);
            Console.WriteLine(automaton.getInitialState());

            // Console.WriteLine(automaton.nextState(1));
            
            automaton.start();

            Console.ReadLine();
        }
    }
}
