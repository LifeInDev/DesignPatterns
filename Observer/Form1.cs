using ObserverPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Observer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        PersonSubscription psubs = new PersonSubscription();

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            
            psubs.AddSubscription(new Subscriber(psubs, txtName.Text, txtSubsType.Text, cboSubsState.Text));
            FillList();
        }

        void FillList()
        {
            listBox1.Items.Clear();
            foreach (var item in psubs.GetSubscribedList())
            {
                listBox1.Items.Add(item.GetSubscriber());
            }            
        }

        private void btnCancelAllSubscription_Click(object sender, EventArgs e)
        {
            psubs.CancelAllSubs = "Pasif";
            psubs.Notify();
            FillList();
        }
    }
}
