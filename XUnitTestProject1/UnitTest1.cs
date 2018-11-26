using System;
using NFluent;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Check
                .That(new Exception())
                .IsSameReferenceAs(new Exception());
        }
    }
}
