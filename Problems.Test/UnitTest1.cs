using NUnit.Framework;
using Problems;


namespace Tests
{
    public class Tests
    {
            //Arrange
            Program test = new Program();
            //Act
           
           
            
            
        //Assert

        [Test]
        public void Test1()
        {
            string results = test.Prefix("hello");
            Assert.AreEqual("5,1:hello",results);
        }

          [Test]
        public void Test2()
        {
            string results1 = test.Prefix("");
            Assert.AreEqual("0,0:",results1);
        }
        [Test]
        public void Test3()
        {
            string results2 = test.Prefix("what  ... did you say??");
            Assert.AreEqual( "23,6:what  ... did you say??",results2);
        }
        

    }
}