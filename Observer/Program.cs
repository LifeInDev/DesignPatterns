using Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ObserverPattern
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
            
                //PersonSubscription psubs = new PersonSubscription();

                //psubs.AddSubscription(new Subscriber(psubs,"Müslüm", "Kişi", "1"));
                //psubs.AddSubscription(new Subscriber(psubs, "Özgür", "Kişi", "1"));
                //psubs.GetSubscribed();

                //psubs.CancelAllSubs = "0";
                //psubs.Notify();

                //psubs.GetSubscribed();
           
            // Wait for user
            //Console.ReadKey();
        }
    }
}
