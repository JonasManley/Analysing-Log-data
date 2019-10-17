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
        public void start()
        {
            //foreach (var item in _alphabet.getAlphabet())

            for (int i = 0; i < _alphabet.size(); i++)
            {
                if (_alphabet.getAlphabet()[i].ToString() == getInitialState())
                {
                    Console.WriteLine("You're logged in");

                    if(_alphabet.getAlphabet()[i+1].ToString() == nextState(i + 1).ToString())
                    {
                        Console.WriteLine("going to option");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                       
                
                    //more happens 
                    //nextState

                    } else { Console.WriteLine("Something went wrong");  }
                
            }
        }

        public string getAlphabet()
        {
            return _alphabet.ToString();
        }

        //start state (givin the name)
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
    }
}
