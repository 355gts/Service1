using Service.Common;
using System;
using System.Threading.Tasks;

namespace Service1
{
    public class ScreenWriter
    {
        private readonly IDoSomething _doSomething;

        public ScreenWriter(IDoSomething doSomething)
        {
            _doSomething = doSomething ?? throw new ArgumentNullException(nameof(doSomething));
        }

        public async Task WriteMessage(int times)
        {
            await _doSomething.PrintMessage(times);
        }
    }
}
