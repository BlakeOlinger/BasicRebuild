using SldWorks;
using System.Threading;

namespace BasicRebuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var swInstance = new SldWorks.SldWorks();
            var model = (ModelDoc2)swInstance.ActiveDoc;

            model.ForceRebuild3(false);

            var delay = 300;

            Thread.Sleep(delay);

            model.ForceRebuild3(false);
        }
    }
}
