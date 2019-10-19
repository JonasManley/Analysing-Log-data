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

            //Valid alphabet strings:
            //login, options, logout, create and list

            //// This will succeed 
            ////
            //Alphabet alphabet = new Alphabet("login options create");
            //Automaton automaton = new Automaton(alphabet);
            //automaton.start();

            //// This will end at secound alphabet (NOT VALID) 
            ////
            //Alphabet alphabet = new Alphabet("login home create");
            //Automaton automaton = new Automaton(alphabet);
            //automaton.start();

            // This will succeed
            //
            Alphabet alphabet = new Alphabet("login options create creates list create create logout");
            Automaton automaton = new Automaton(alphabet);
            automaton.start();

            //// This will end at sixth alphabet (NOT VALID)
            ////
            //Alphabet alphabet1 = new Alphabet("login options create create list options create logout");
            //Automaton automaton1 = new Automaton(alphabet1);
            //automaton1.start();

            Console.ReadLine();
        }
    }
}
