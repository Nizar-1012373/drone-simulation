using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class TestMotor
    {
        [Fact]
        public void TestIfMotorStarts()
        {
            var motor = new Motor();
            bool result = motor.IsStarting(true);
            

            Assert.True(result, "The motor is not starting");
        }

        public void TestIfMotorIsSpeedingUp(){
            var motor = new Motor();
            int expectedResult = motor.IsSpeedingUp(100);
            int actualResult = 20;

            Assert.Equal(expectedResult,actualResult);
        }
    }
}