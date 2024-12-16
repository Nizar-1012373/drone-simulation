using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class TestMotor
    {
        [Fact]
        public void IsPrime_InputIs1_ReturnFalse()
        {
            var motor = new Motor();
            bool result = motor.IsStarting(false);

            Assert.True(result, "The motor is not starting");
        }
    }
}