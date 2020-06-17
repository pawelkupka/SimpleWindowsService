using System;
using System.IO;
using System.Timers;

namespace SimpleWindowsService
{
    public class SimpleService
    {
        private readonly Timer _timer;

        public SimpleService()
        {
            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += TimerElapsed;
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            string[] lines = new string[] { DateTime.Now.ToString() };
            File.AppendAllLines(@"C:\my-services\SimpleWindowsService\data.txt", lines);
        }

        public void Start()
        {
            _timer.Start();
        }

        public void Stop()
        {
            _timer.Stop();
        }
    }
}
