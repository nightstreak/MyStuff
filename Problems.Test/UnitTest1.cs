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
            string results1 = test.Prefix("");
            Assert.AreEqual("0,0:",results1);
            string results2 = test.Prefix("what  ... did you say??");
            Assert.AreEqual( "23,6:what  ... did you say??",results2);
            string results3 = test.Prefix("... I am ...");
            Assert.AreEqual( "12,4:... I am ...",results3);
            string results4 = test.Prefix("Woop... Scoop");
            Assert.AreEqual( "13,2:Woop... Scoop",results4);
             string results5 = test.Prefix("Hey Jump");
            Assert.AreEqual( "8,2:Hey Jump",results5);
            
        }

        

    }
}