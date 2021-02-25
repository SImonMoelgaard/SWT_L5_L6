using System;
using NSubstitute;
using NUnit.Framework;
using SWT_L5_6_Interfaces;

namespace NUnitTestProject
{
    [TestFixture]
    public class Tests
    {
        private Ecs _uut;
        private IHeater _heater;
        private ITempSensor _tempsensor;
        [SetUp]
        public void Setup()
        {
            _heater = Substitute.For<IHeater>();
            _tempsensor = Substitute.For<ITempSensor>();
            _uut = new Ecs(25,_tempsensor,_heater);
            //Ecs_ctor_inject();
        }

        [Test]
        public void Ecs_ctor_inject()
        {
            //_uut = new Ecs(5, new FakeTempSensor(5), new FakeHeater(true));
            
        }

        [Test]
        public void GetThreshold()
        {
            Assert.That(_uut.GetThreshold(), Is.EqualTo(25));
        }


        [Test]
        public void Regulate()
        {

            _tempsensor.GetTemp().Returns(24);
            _uut.Regulate();
            _heater.Received(1).TurnOn();



            //FakeTempSensor fakeTempTest = new FakeTempSensor(1);
            //FakeHeater fakeHeaterTest = new FakeHeater(false);
            //_uut = new Ecs(5, fakeTempTest, fakeHeaterTest);
            //_uut.SetThreshold(2);
            

            //_uut.Regulate();
            //Assert.IsTrue(fakeHeaterTest.Answer);
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
            _tempsensor.GetTemp().Returns(5);
            Assert.That(_uut.GetCurTemp(),Is.EqualTo(5));
            
            
        }


        [Test]
        public void RunSelfTest()
        {
            _tempsensor.RunSelfTest().Returns(false);
            _heater.RunSelfTest().Returns(true);
            Assert.IsFalse(_uut.RunSelfTest());
        }

    }
}