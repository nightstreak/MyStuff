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
         [Test]
        public void Test4()
        {
            string results3 = test.Prefix("I have 99  problems !!");
            Assert.AreEqual("22,6:I have 99  problems !!",results3);
        }
         [Test]
        public void Test5()
        {
            string results4 = test.Prefix("Wool is not nice.");
            Assert.AreEqual("17,4:Wool is not nice.",results4);
        }
         public void Test6()
        {
            string results5 = test.Prefix("....I'm fine....  ");
            Assert.AreEqual("18,4:....I'm fine....",results5);
        }
        

    }
}