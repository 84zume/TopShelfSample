using Topshelf;

namespace TopShelfSample
{
    public class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>
            {
                x.Service<Beat>(s =>
                {
                    s.ConstructUsing(name => new Beat());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();
                x.SetDescription("Just beating program");
                x.SetDisplayName("BeatingProgram");
                x.SetServiceName("BeatingService");
            });
        }
    }
}
