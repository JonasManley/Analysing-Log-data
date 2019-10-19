using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysing_Log_data
{
    class Automaton : IAutomaton
    {
        private Alphabet _alphabet;
        private List<State> states = new List<State>();

        public Automaton(Alphabet alphabet)
        {
            _alphabet = alphabet;

            //Posible states
            states.Add(new State("login", false));
            states.Add(new State("options", false));
            states.Add(new State("logout", false));
            states.Add(new State("create", true));
        }

        //logic 
        private int numberTrue = 0;
        public void start()
        {
            //first you must login 
            if (_alphabet.getAlphabet()[0].ToString() == getInitialState())
            {
                Console.WriteLine("You're logged in");
                if (_alphabet.getAlphabet()[1].ToString() == nextState(1).ToString())
                {
                    Console.WriteLine("you've choose: options");
                    if (_alphabet.getAlphabet()[2].ToString() == nextState(2).ToString() || _alphabet.getAlphabet()[2].ToString() == nextState(3).ToString())
                    {
                        if (_alphabet.getAlphabet()[2].ToString() == nextState(2).ToString())
                        {
                            Console.WriteLine("you've choose: logout");
                        }
                        if (_alphabet.getAlphabet()[2].ToString() == nextState(3).ToString())
                        {
                            Console.WriteLine("you've choose: create");
                        }
                    }
                    else { Console.WriteLine("Third alphabet is not a acceptalbe state"); }
                }
                else { Console.WriteLine("Secound alphabet is not a acceptalbe state"); }
            }
            else { Console.WriteLine("frist alphabet is not a acceptalbe state"); }
        }

        //returns the alphabet (in form of a list)
        public string getAlphabet()
        {
            return _alphabet.ToString();
        }

        //start state 
        public string getInitialState()
        {
            return states[0].ToString();
        }

        public List<State> getStates()
        {
            throw new NotImplementedException();
        }

        public State nextState(int index)
        {
            return states[index];
        }

        private bool Comparer(string x, string y)
        {
            if(x == y)
            {
                return true;
            }return false;
        }
    }
}
