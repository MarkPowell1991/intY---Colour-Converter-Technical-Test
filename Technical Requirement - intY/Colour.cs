using System;
using System.Collections.Generic;
using System.Text;

namespace Technical_Requirement___intY
{

    public class Colour
    {


        private string name { get; set; }

        private string RgbCode { get; set; }

        private string HexCode { get; set; }


        private List<Colour> colours = new List<Colour>();

        public Colour()
        {
        }

        public Colour(string name, string rgbCode, string hexCode)
        {
            this.name = name;
            this.RgbCode = rgbCode;
            this.HexCode = hexCode;
        }

       

        private void CreateColours()
        {
            colours.Add(new Colour("red", "rgb(255,0,0)", "#ff0000"));
            colours.Add(new Colour("orange", "rgb(255,165,0)", "#ffa500"));
            colours.Add(new Colour("yellow", "rgb(255,255,0)", "#ffff00"));
            colours.Add(new Colour("green", "rgb(0,128,0)", "#008000"));
            colours.Add(new Colour("blue", "rgb(0,0,255)", "#0000ff"));
            colours.Add(new Colour("indigo", "rgb(75,0,130)", "#4b0082"));
            colours.Add(new Colour("violet", "rgb(238,130,238)", "#ee82ee"));
        }

        public string GetName()
        {
            return name;
        }

        public string GetRgbValue()
        {
            return RgbCode;
        }

        public string GetHexValue()
        {
            return HexCode;
        }

        public List<Colour> GetColours()
        {
            CreateColours();
            return colours;
        }
    }

    




}
