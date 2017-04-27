using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();

            if (x == "1")
            {

                // Configure Observer pattern
                ConcreteSubject s = new ConcreteSubject();

                s.Attach(new ConcreteObserver(s, "X"));
                s.Attach(new ConcreteObserver(s, "Y"));
                s.Attach(new ConcreteObserver(s, "Z"));

                // Change subject and notify observers
                s.SubjectState = "ABC";
                s.Notify();
            }
            else
            {
                // Create IBM stock and attach investors
                IBM ibm = new IBM("IBM", 120.00);
                ibm.Attach(new Investor("Sorros"));
                ibm.Attach(new Investor("Berkshire"));                

                // Fluctuating prices will notify investors
                ibm.Price = 120.10;
                ibm.Price = 121.00;
                ibm.Price = 120.50;
                ibm.Price = 120.75;                
            }


            // Wait for user
            Console.ReadKey();
        }

        abstract class Subject
        {
            private List<Observer> _observers = new List<Observer>();

            public void Attach(Observer observer)
            {
                _observers.Add(observer);
            }

            public void Detach(Observer observer)
            {
                _observers.Remove(observer);
            }

            public void Notify()
            {
                foreach (Observer o in _observers)
                {
                    o.Update();
                }
            }
        }

        class ConcreteSubject : Subject
        {
            private string _subjectState;

            // Gets or sets subject state
            public string SubjectState
            {
                get { return _subjectState; }
                set { _subjectState = value; }
            }
        }

        abstract class Observer
        {
            public abstract void Update();
        }

        class ConcreteObserver : Observer
        {
            private string _name;
            private string _observerState;
            private ConcreteSubject _subject;

            // Constructor
            public ConcreteObserver(
              ConcreteSubject subject, string name)
            {
                this._subject = subject;
                this._name = name;
            }

            public override void Update()
            {
                _observerState = _subject.SubjectState;
                Console.WriteLine("Observer {0}'s new state is {1}",
                  _name, _observerState);
            }

            // Gets or sets subject
            public ConcreteSubject Subject
            {
                get { return _subject; }
                set { _subject = value; }
            }
        }
    }
}
