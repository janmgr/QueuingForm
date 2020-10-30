using System;
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
    public partial class NowServingForm : Form
    {
        public NowServingForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NowServingForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (CashierClass.CashierQueue.Count == 0)
                {
                    throw new ArgumentNullException("No queue");
                }
                else
                {
                    lblNowServing.Text = CashierClass.CashierQueue.Peek();
                    timer1.Start();
                }
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message);
                this.Close();
            }
        }

        private int ticker = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ticker <= 3)
            {
                ticker++;
            }
            else
            {
                CashierClass.CashierQueue.Dequeue();
                timer1.Stop();
                this.Close();
            }
        }
    }
}
