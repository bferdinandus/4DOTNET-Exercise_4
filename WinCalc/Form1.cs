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

            _timeRemaining = 3;
            timeRemainingLabel.Text = _timeRemaining.ToString();
            timer1.Start();

            //AsyncSteentijd(a, b);

            //AsyncMiddeleeuwen(a, b);

            AsyncDerModerneMensch(a, b);

        }

        private async void AsyncDerModerneMensch(decimal a, decimal b)
        {
            /*var t1 = Task.Run(() => Add(a, b));
            await t1; //zachte return. de functie wordt geparkeerd totdat de await klaar is
            UpdateAnswer(t1.Result);*/

            try
            {
                /*decimal res = await AddAsync(a, b);
                UpdateAnswer(res);*/
                UpdateAnswer(await AddAsync(a, b));
            }
            catch (Exception e)
            {
                string res = e.Message;
                UpdateAnswer(res);
            }
        }

        private void AsyncMiddeleeuwen(decimal a, decimal b)
        {
            var ctx = SynchronizationContext.Current;
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

        private void AsyncSteentijd(decimal a, decimal b)
        {
            var ctx = SynchronizationContext.Current;

            // een delegate kan je asynchroon starten dmv BeginInvoke
            Func<decimal, decimal, decimal> add = Add;
            IAsyncResult ar = add.BeginInvoke(a, b, ar2 =>
            {
                ctx.Post(UpdateAnswer, add.EndInvoke(ar2));
            }, null);
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
            //throw new Exception("Oepsje, gaat mis");

            return a + b;
        }

        private Task<decimal> AddAsync(decimal a, decimal b)
        {
            return Task.Run(() => Add(a, b));
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
