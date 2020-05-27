using System;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestProjectCore
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Task.Delay(10).Wait();
        }
    }
}
