using NUnit.Framework;
using System;
using System.Collections.Generic;
using Technical_Requirement___intY;

namespace TechnicalRequirementNunitTests
{
   

    [TestFixture]
    public class ColourTests
    {
        //Getname Must return name
        //GetRGBValue Must return RGBValue
        //GetHexValue must return HexValue
        //GetColours Must return all 7 colours

        [Test]
        public void Colours_GetColours_Returns7Colours()
        {

            //Arrange
            List<Colour> colours = new List<Colour>();
            Colour col = new Colour();

            //Act
            colours = col.GetColours();
            int ListSize = colours.Count;

            //Assert
            Assert.AreEqual(7, ListSize);
        }

        [Test]
        public void Colours_GetName_WhenRed_ReturnRed()
        {
            //Arrange
            Colour col = new Colour("red", "rgb(255,0,0)", "#ff0000");
            //Act
            string name = col.GetName();
            //Assert
            Assert.AreEqual("red", name);
        }

        [Test]
        public void Colours_GetRgbValue_WhenRed_ReturnRed()
        {
            //Arrange
            Colour col = new Colour("red", "rgb(255,0,0)", "#ff0000");
            //Act
            string name = col.GetRgbValue();
            //Assert
            Assert.AreEqual("rgb(255,0,0)", name);
        }

        [Test]
        public void Colours_GetHexValue_WhenRed_ReturnRed()
        {
            //Arrange
            Colour col = new Colour("red", "rgb(255,0,0)", "#ff0000");
            //Act
            string name = col.GetHexValue();
            //Assert
            Assert.AreEqual("#ff0000", name);
        }

    }

    [TestFixture]
    public class InstructionsTests
    {

        //Set team must not allow invalid input
        //HandleResponse must not accept invalid input
        //HandleReponse must Change Team value if team input is given
        //HandleResponse must return a conversion if a colour is added


        [Test]
        public void Instructions_SetTeamHello_ReturnRGB()
        {
            //Arrange
            Instructions ins = new Instructions();
            //Act
            ins.SetTeam("Hello");
            string result = ins.GetTeam();
            //Assert
            Assert.AreEqual("rgb", result);
        }
    }



    [TestFixture]
    public class TextLoggerTests
    {


        //Log must write to .txt  file
        //Log should write the chosen message i.e conversion : timestamp

        [Test]
        public void TextLogger_GivesString_ReturnsLog()
        {

            //Arrange
            TextLogger tl = new TextLogger();
            string input = "This is a Test";

            //Act
            tl.LogConversion(input);
            string output = tl.GetLog();

            //Assert
            Assert.AreEqual("This is a Test" + " : " + DateTime.Now.ToString(), output);
        }



    }
}