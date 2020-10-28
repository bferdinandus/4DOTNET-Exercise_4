using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCalc
{
    public partial class Form1 : Form
    {
        private int _timeRemaining;

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal a = getalAUpDown.Value;
            decimal b = getalBUpDown.Value;

            _timeRemaining = 10;
            timeRemainingLabel.Text = _timeRemaining.ToString();
            timer1.Start();

            var ctx = SynchronizationContext.Current;
            Func<decimal, decimal, decimal> add = Add;

            IAsyncResult ar = add.BeginInvoke(a, b, ar2 => ctx.Post(UpdateAnswer, add.EndInvoke(ar2)), null);
        }

        private void UpdateAnswer(object result)
        {
            answerLabel.Text = result.ToString();
        }

        private decimal Add(decimal a, decimal b)
        {
            Task.Delay(_timeRemaining * 1000).Wait();

            return a + b;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeRemainingLabel.Text = (--_timeRemaining).ToString();

            if (_timeRemaining < 1)
            {
                timeRemainingLabel.Text = "";
                timer1.Stop();
            }
        }
    }
}
