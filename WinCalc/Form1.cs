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

            _timeRemaining = 4;
            timeRemainingLabel.Text = _timeRemaining.ToString();
            timer1.Start();

            var ctx = SynchronizationContext.Current;
            /*
            // een delegate kan je asynchroon starten dmv BeginInvoke
            Func<decimal, decimal, decimal> add = Add;
            IAsyncResult ar = add.BeginInvoke(a, b, ar2 =>
            {
                ctx.Post(UpdateAnswer, add.EndInvoke(ar2));
            }, null);*/
                        
            var x = Task.Run(() =>
            {
                return Add(a, b);
            }).ContinueWith(pt =>
            {
                /*if (pt.Exception != null)
                {
                    Console.WriteLine(pt.Exception.InnerException);
                }*/
                ctx.Post(UpdateAnswer, pt.Result);
            });

            
        }

        private void UpdateAnswer(object result)
        {
            /*if (answerLabel.InvokeRequired)
            {
                answerLabel.Invoke((MethodInvoker)delegate { UpdateAnswer(result); });
            }*/

            answerLabel.Text = result.ToString();
        }

        private decimal Add(decimal a, decimal b)
        {
            Task.Delay(_timeRemaining * 1000).Wait(); // long blocking action

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
