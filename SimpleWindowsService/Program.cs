using System;
using Topshelf;

namespace SimpleWindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            var exitCode = HostFactory.Run(x =>
            {
                x.Service<SimpleService>(s =>
                {
                    s.ConstructUsing(heartbeat => new SimpleService());
                    s.WhenStarted(heartbeat => heartbeat.Start());
                    s.WhenStopped(heartbeat => heartbeat.Stop());
                });

                x.RunAsLocalSystem();
                x.StartManually();
                x.SetServiceName("SimpleWindowsService");
                x.SetDisplayName("Simple Windows Service");
                x.SetDescription("This is the simple windows service.");
            });

            int exitCodeValue = (int)Convert.ChangeType(exitCode, exitCode.GetTypeCode());
            Environment.ExitCode = exitCodeValue;
        }
    }
}
