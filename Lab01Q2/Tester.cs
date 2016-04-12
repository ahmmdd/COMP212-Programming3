/*
 * 2.
 * Develop a console application in C# that uses a custom event. The application
 * should have at least 3 classes: a Publisher class that publishes the event for
 * other classes to subscribe, a Subscriber class that subscribes the event 
 * offered by the Publisher class, and a Tester class that runs the application. 
 * If you run the application, every 5 seconds it will raise the custom event 
 * handler created by you. The event handler reports to the user that the event
 * was heard. 
 * 
 * This is a Tester Class.
 * 
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;

namespace Lab01Q2{
    public class Time : EventArgs {
        private DateTime TimeNow;
        public DateTime Timer{
            set { TimeNow = value; }
            get { return this.TimeNow; }
        }
    }
    public class TimeHandler {
        public event TickHandler Tick;
        public delegate void TickHandler(TimeHandler m, Time e);
        public void Start() {
            while (true) {
                System.Threading.Thread.Sleep(5000);
                if (Tick != null) {
                    Time TOT = new Time();
                    TOT.Timer = DateTime.Now;
                    Tick(this, TOT);
                }
            }
        }
    }
    public class Counter {
        public void Subscribe(TimeHandler m){
            m.Tick += new TimeHandler.TickHandler(HeardIt);
        }
        private void HeardIt(TimeHandler m, Time e){
            System.Console.WriteLine("HEARD IT AT {0}", e.Timer);
        }
    }
    class Tester {
        static void Main() {
            TimeHandler timeHandler = new TimeHandler();
            Counter l = new Counter();
            l.Subscribe(timeHandler);
            timeHandler.Start();
        }
    }
}//End Namespace
