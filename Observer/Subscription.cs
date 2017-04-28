using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverPattern
{
    abstract class Subscription
    {
        private List<ISubscription> _subscription = new List<ISubscription>();

        public virtual void AddSubscription(ISubscription subscription)
        {
            _subscription.Add(subscription);
        }

        public void RemoveSubscription(ISubscription subscription)
        {
            _subscription.Remove(subscription);
        }

        public List<ISubscription> GetSubscribedList()
        {
            return _subscription;
        }

        public void GetSubscribed()
        {
            foreach (var subscribed in _subscription)
            {
                Console.WriteLine(subscribed.GetSubscriber());
            }
        }

        public void GetSubscribedCount()
        {
            Console.WriteLine(_subscription.Count);
        }

        public void Notify()
        {
            foreach (var item in _subscription)
            {
                item.UpdateSubsState();
            }
        }
    }

    class PersonSubscription : Subscription
    {
        private string _subsState;
        public string CancelAllSubs
        { get { return _subsState; } set { _subsState = value; } }
    }    

    interface ISubscription
    {
        string GetSubscriber();
        void UpdateSubsState();
    }

    class Subscriber : ISubscription
    {
        string _subscriberName;
        string _subscriberType;
        string _subscribeState;
        private PersonSubscription _personSubs;

        public Subscriber(PersonSubscription psubs, string subscriberName, string subscriberType, string subscribeState)
        {
            this._personSubs = psubs;
            this._subscriberName = subscriberName;
            this._subscriberType = subscriberType;
            this._subscribeState = subscribeState;
        }

        public string GetSubscriber()
        {
            return _subscriberName + " - " + _subscriberType + " - " + _subscribeState;
        }

        public void UpdateSubsState()
        {
            _subscribeState = _personSubs.CancelAllSubs;            
        }

        public PersonSubscription pSubs
        {
            get { return _personSubs; }
            set { _personSubs = value; }
        }
    }
}
