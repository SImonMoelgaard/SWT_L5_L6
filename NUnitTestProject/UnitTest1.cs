using System;
using NUnit.Framework;
using SWT_L5_6_Interfaces;

namespace NUnitTestProject
{
    [TestFixture]
    public class Tests
    {
        private Ecs _uut;
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void ecs_ctor_inject()
        {

            _uut = new Ecs(5);
            
        }

        [Test]
        public void GetThreshold()
        {
            
            Assert.That(_uut.GetThreshold(), Is.EqualTo(5));
        }


        [Test]
        public void Regulate()
        {
            try
            {
                _uut.Regulate();
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }


        [TestCase(2)]
        public void SetThreshold(int thr)
        {
            try
            {
                _uut.SetThreshold(2);
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }
        [Test]
        public void GetCurTemp()
        {
            try
            {
                _uut.GetCurTemp();
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }


        [Test]
        public void Runselftest()
        {
            try
            {
                _uut.RunSelfTest();
                Assert.IsTrue(true);
            }
            catch (Exception e)
            {
                Assert.Fail();
            }
        }

    }
}