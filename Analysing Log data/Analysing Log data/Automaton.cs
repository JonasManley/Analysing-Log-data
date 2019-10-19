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

        /// <summary>
        ///  You can login, go to options and the have 3 options (create, list of cars or logout) 
        /// </summary>
        /// <param name="alphabet">the actions that the user wants to execute if possible</param>
        public Automaton(Alphabet alphabet)
        {
            _alphabet = alphabet;

            //Posible states
            states.Add(new State("login", false));
            states.Add(new State("options", false));
            states.Add(new State("logout", false));
            states.Add(new State("create", true));
            states.Add(new State("list", true));
        }

        /// <summary>
        /// Logic that defines the right alphabet (routes)
        /// </summary>
        bool succesfully = false;
        public void start()
        {
            var CurrentDate = DateTime.Now; 
            Check();
            if (_alphabet.getAlphabet()[0].ToString() == getInitialState())
            {
                Console.WriteLine("ACTION: You're logged in                  " + CurrentDate);
                if (_alphabet.getAlphabet()[1].ToString() == nextState(1).ToString())
                {
                    Console.WriteLine("ACTION: you've choose: options            " + CurrentDate);

                    for (int i = 2; i < _alphabet.getAlphabet().Count(); i++)
                    {
                        if (_alphabet.getAlphabet()[i].ToString() == nextState(2).ToString() ||
                        _alphabet.getAlphabet()[i].ToString() == nextState(3).ToString() ||
                        _alphabet.getAlphabet()[i].ToString() == nextState(4).ToString())
                        {
                            if (_alphabet.getAlphabet()[i].ToString() == nextState(2).ToString())
                            {
                                Console.WriteLine("ACTION: you've choose: logout            " + CurrentDate);
                                Console.WriteLine("Automaton has ended");
                                Console.WriteLine();
                                Console.WriteLine("press enter to close");
                                Console.ReadLine();
                                succesfully = true;
                                break;
                            }
                            if (_alphabet.getAlphabet()[i].ToString() == nextState(3).ToString() && succesfully != true)
                            {
                                Console.WriteLine("ACTION: you've choose: create             " + CurrentDate);
                                continue;
                            }
                            if (_alphabet.getAlphabet()[i].ToString() == nextState(4).ToString() && succesfully != true)
                            {
                                Console.WriteLine("ACTION: you've choose: list               " + CurrentDate);
                                continue;
                            }
                        }
                        else { Console.WriteLine(); Console.WriteLine("ERROR: Third alphabet is not a acceptalbe state"); Console.WriteLine("Automaton has ended"); return; }
                    }
                }
                else { Console.WriteLine(); Console.WriteLine("ERROR: Secound alphabet is not a acceptalbe state"); Console.WriteLine("Automaton has ended"); return; }
            }
            else { Console.WriteLine(); Console.WriteLine("ERROR: frist alphabet is not a acceptalbe state"); Console.WriteLine("Automaton has ended"); return; }
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

        public State nextState(int index)
        {
            return states[index];
        }

        private void Check()
        {
            Console.WriteLine("Analysing Your Alphabet");
            System.Threading.Thread.Sleep(1500);
            List<string> statesStringList = new List<string>();
            foreach (var item in states)
            {
                statesStringList.Add(item.ToString());
            }

            foreach (var item in _alphabet.getAlphabet())
            {
                Console.WriteLine("Variable is: " + statesStringList.Contains(item));
                System.Threading.Thread.Sleep(200);
            }
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            Console.WriteLine("VALID: The giving Alphabet is ok");
            Console.WriteLine("----------------------Starting the automaton----------------------");
            System.Threading.Thread.Sleep(1500);
        }

        
        //private bool Comparer(string x, string y)
        //{
        //    if(x == y)
        //    {
        //        return true;
        //    }return false;
        //}
    }
}
