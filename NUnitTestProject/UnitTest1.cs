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
            Ecs_ctor_inject();
        }

        [Test]
        public void Ecs_ctor_inject()
        {
            _uut = new Ecs(5, new FakeTempSensor(5), new FakeHeater(true));
            
        }

        [Test]
        public void GetThreshold()
        {
            Assert.That(_uut.GetThreshold(), Is.EqualTo(5));
        }


        [Test]
        public void Regulate()
        {

          
            FakeTempSensor fakeTempTest = new FakeTempSensor(1);
            FakeHeater fakeHeaterTest = new FakeHeater(false);
            _uut = new Ecs(5, fakeTempTest, fakeHeaterTest);
            _uut.SetThreshold(2);
            

            _uut.Regulate();
            Assert.IsTrue(fakeHeaterTest.Answer);
        }


        [TestCase(4)]
        public void SetThreshold(int thr)
        {

            _uut.SetThreshold(thr);
            Assert.That(_uut.GetThreshold(),Is.EqualTo(4));
            //try
            //{
            //    _uut.SetThreshold(thr);
            //    Assert.IsTrue(true);
            //}
            //catch (Exception e)
            //{
            //    Assert.Fail();
            //}
        }
        [Test]
        public void GetCurTemp()
        {
            
            Assert.That(_uut.GetCurTemp(),Is.EqualTo(5));
            
            
        }


        [Test]
        public void RunSelfTest()
        {
            _uut.RunSelfTest();
            Assert.IsTrue(true);
        }

    }
}