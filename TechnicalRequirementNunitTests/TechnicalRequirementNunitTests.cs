using NUnit.Framework;
using Technical_Requirement___intY;

namespace TechnicalRequirementNunitTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }





    }

    [TestFixture]
    public class ColourTests
    {
        //constructor must for a valid colour object
        //Getname Must return name
        //GetRGBValue Must return RGBValue
        //GetHexValue must return HexValue
        //GetColours Must return all 7 colours

   
      
    }

    [TestFixture]
    public class InstructionsTests
    {

        //Set team must not allow invalid input
        //HandleResponse must not accept invalid input
        //HandleReponse must Change Team value if team input is given
        //HandleResponse must return a conversion if a colour is added


        [Test]
        public void TestMethod1()
        {

        }
    }

    [TestFixture]
    public class ProgramTests
    {

        //
        //
        //

        [Test]
        public void TestMethod1()
        {

        }
    }


    [TestFixture]
    public class TextLoggerTests
    {


        //Log must write to .txt  file
        //Log should write the chosen message i.e conversion : timestamp

        

        [TestCase("The RGB value for red is rgb(255,0,0) ", "converted red to RGB: 16 / 12 / 2021 18:09:49")]
        public void LogConversion_WriteLog_ReturnLog(string input, string expected)
        {

            TextLogger tl = new TextLogger();
            tl.LogConversion(input);
            //Assert.AreEqual(expected, actual);


        }

    }
}