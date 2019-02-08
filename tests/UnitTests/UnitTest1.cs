using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
       
        [Fact]
        public void CubeofANumber()
        {
            var expected = 27;
            var a = 3;
            
            var actual = Cube(a);
            Assert.Equal(expected,actual);
        }

          [Theory]
        [InlineData(8,2)]
        [InlineData(64,4)]
        [InlineData(125, 5)]
        public void Cube_WorksWithManyInputs(int exp, int n1)
        {
            Assert.Equal(exp, Cube(n1));
        }

        int Cube(int x)
        {
            return x*x*x;
        }
    }
}
