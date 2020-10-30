using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CashierWindowQueueForm : Form
    {
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach(Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
            
        }
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NowServingForm nsf = new NowServingForm();
            nsf.Show();
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

        private void CashierWindowQueueForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
