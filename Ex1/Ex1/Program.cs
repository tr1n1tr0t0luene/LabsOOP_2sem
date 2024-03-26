using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ex1
{
    public delegate void TimerDelegate(int seconds);

    public class Timer
    {
        private TimerDelegate timerDelegate;
        private int interval;
        private Thread thread;

        public Timer(TimerDelegate timerDelegate, int interval)
        {
            this.timerDelegate = timerDelegate;
            this.interval = interval;
            this.thread = new Thread(Run);
        }

        public void Start()
        {
            thread.Start();
        }

        public void Stop()
        {
            thread.Abort();
        }

        private void Run()
        {
            while (true)
            {
                timerDelegate(interval);
                Thread.Sleep(interval * 1000);
            }
        }
    }

    class Program
    {
        static void ShowMessage(int seconds)
        {
            Console.WriteLine($"Пройшло {seconds} секунд");
        }

        static void Main(string[] args)
        {
            Timer timer1 = new Timer(ShowMessage, 5);
            Timer timer2 = new Timer(ShowMessage, 10);
            timer1.Start();
            timer2.Start();
            Thread.Sleep(30 * 1000);
            timer1.Stop();
            timer2.Stop();
        }
    }

}
