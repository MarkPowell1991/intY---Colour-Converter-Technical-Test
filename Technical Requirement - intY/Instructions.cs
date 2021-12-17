using System;
using System.Collections.Generic;
using System.Text;
using Technical_Requirement___intY;

namespace Technical_Requirement___intY
{
    //refers to instructions given to and displayed in the command line.
    public class Instructions
    {

        private string Team = "rgb";
        List<Colour> colours = new List<Colour>();
        Colour col = new Colour();
        public string terminalResult = "";
        bool valid = false;

        //validation:
        //input must be one of the given colours, else return error code
        public void SetTeam(string team)
        {
            if (team == "rgb" || team == "hex")
            {
                Team = team;
            }
            else
            {
                GiveInstruction("InputError");
            }
        }

        public string GetTeam()
        {
            return Team;
        }

        //
        public void HandleResponse(string uInput)
        {

            //check input is either team declarration or a selected colour
            valid = false;

            TextLogger tl = new TextLogger();
            string input = uInput.ToLower();
            //im aware this check is also done in the validation but i needed a way to seperate a team change command from a colour conversion request. ill try and look in to smartening this up later.
            if (colours.Count == 0)
            {
                colours = col.GetColours();
            }
            if (input == "rgb" || input == "hex")
            {
                SetTeam(input);
                valid = true;
            }
            else
                for (int i = 0; i < colours.Count; i++)
                {
                    if (input == colours[i].GetName())
                    {
                        if (Team == "rgb")
                        {
                            Console.WriteLine($"");
                            Console.WriteLine($"The RGB value for {input} is {colours[i].GetRgbValue()}");
                            Console.WriteLine($"");
                            tl.LogConversion($"converted { colours[i].GetName()} to RGB ");
                            valid = true;
                        }
                        else if (Team == "hex")
                        {
                            Console.WriteLine($"");
                            Console.WriteLine($"The Hex value for {input} is {colours[i].GetHexValue()}");
                            Console.WriteLine($"");
                            tl.LogConversion($"converted { colours[i].GetName()} to Hex ");
                            valid = true;
                        }
                    }
                }
            if (valid == false)
            {
                tl.LogConversion($"Invalid Input given");
                GiveInstruction("InputError");
            }
        }


        //expected input types. Team, Colour
        public void GiveInstruction(string instruction)
        {
            switch (instruction)
            {

                case "Introduction":
                    Console.WriteLine($"");
                    Console.WriteLine($"Hello. Welcome to Mark Powells Colour Converting Console Application ");
                    break;
                case "WhichTeam":
                    Console.WriteLine($"Are you a member of team 1(RGB) or team 2(HEX)?");
                    Console.WriteLine($"");
                    Console.WriteLine($"RGB");
                    Console.WriteLine($"HEX");
                    Console.WriteLine($"");
                    break;

                case "WhichColour":
                    Console.WriteLine($"");
                    Console.WriteLine($"Please input the colour you wish to convert from the options given below.");
                    Console.WriteLine($"");
                    for (int i = 0; i < colours.Count; i++)
                    {
                        Console.WriteLine(colours[i].GetName());
                    }
                    Console.WriteLine($"");
                    break;

                //case "ReturnColour":
                //    //if user is team1, return colour + RGB. If user is team2, return colour + HEX.
                //    Console.WriteLine("");
                //    break;

                case "Logging":
                    Console.WriteLine($" your conversion has been logged");
                    break;
                case "InputError":
                    Console.WriteLine($"sorry, unable to recognise input. Please stick to the options given.");
                    break;
            }
        }


    }
}
