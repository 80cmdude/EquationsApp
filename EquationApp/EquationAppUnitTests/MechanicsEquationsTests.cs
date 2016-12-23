using System;
using NUnit.Framework;
using EquationApp.Controllers.Equations;

namespace EquationAppUnitTests
{
    [TestFixture]
    public class MechanicsEquationsTests
    {
        [Test]
        public void VDT_Can_Calculate_Velocity()
        {
            var velocity = Velocity_VDT.GetVelocity("100", "10");
            Assert.IsTrue(velocity == (decimal)10);
        }

        [Test]
        public void VDT_Can_Calculate_Distance()
        {
            var distance = Velocity_VDT.GetDistance("100", "10");
            Assert.IsTrue(distance == (decimal)1000);
        }

        [Test]
        public void VDT_Can_Calculate_Time()
        {
            var time = Velocity_VDT.GetTime("10", "100");
            Assert.IsTrue(time == (decimal)10);
        }

        [Test]
        public void VUAT_Can_Calculate_FinalVelocity()
        {
            var finalVelocity = Velocity_VUAT.getFinalVelocity("100", "10", "10");
            Assert.IsTrue(finalVelocity == (decimal)200);
        }

        [Test]
        public void VUAT_Can_Calculate_InitialVelocity()
        {
            var initialVelocity = Velocity_VUAT.getInitialVelocity("1000", "1", "50");
            Assert.IsTrue(initialVelocity == (decimal)950);
        }

        [Test]
        public void VUAT_Can_Calculate_Acceleration()
        {
            var acceleration = Velocity_VUAT.getAcceleration("100", "1", "5");
            Assert.IsTrue(acceleration == (decimal)19.8);
        }

        [Test]
        public void VUAT_Can_Calculate_Time()
        {
            var time = Velocity_VUAT.getTime("200", "100", "50");
            Assert.IsTrue(time == (decimal)2);
        }
    }
}
