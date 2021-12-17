using System;

namespace Technical_Requirement___intY
{



    public class Program
    {


        //Ask the user which team they belong to in the command line
        //write initial instructions to command line - perhaps the list of availuable colours?
        //read user input//
        //return colour code in a format dependant on which team they belong to(team 1 = RGB, team 2 = HEX)
        //Add conversion results to the .txt file
        static void Main(string[] args)
        {
            Instructions ins = new Instructions();


            ins.GiveInstruction("Introduction");
            ins.GiveInstruction("WhichTeam");

            while(true) { //this is to stop it automatically closing the console once its run through once
            ins.HandleResponse(Console.ReadLine());
            ins.GiveInstruction("WhichColour");
            }
        }



    }
}
