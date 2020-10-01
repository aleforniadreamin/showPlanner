using System;

namespace NetflixPlanner
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables
            Dashboard homePage = new Dashboard();

            System.Console.WriteLine("============================================================================================================================================");
            //Jumbotron
            System.Console.WriteLine(".__   __.  _______ .___________. _______  __        __  ___   ___    .______    __          ___      .__   __. .__   __.  _______ .______      ");
            System.Console.WriteLine("|  \\ |  | |   ____||           ||   ____||  |      |  | \\  \\ /  /    |   _  \\  |  |        /   \\     |  \\ |  | |  \\ |  | |   ____||   _  \\     ");
            System.Console.WriteLine("|   \\|  | |  |__   `---|  |----`|  |__   |  |      |  |  \\  V  /     |  |_)  | |  |       /  ^  \\    |   \\|  | |   \\|  | |  |__   |  |_)  |    ");
            System.Console.WriteLine("|  . `  | |   __|      |  |     |   __|  |  |      |  |   >   <      |   ___/  |  |      /  /_\\  \\   |  . `  | |  . `  | |   __|  |      /     ");
            System.Console.WriteLine("|  |\\   | |  |____     |  |     |  |     |  `----. |  |  /  .  \\     |  |      |  `----./  _____  \\  |  |\\   | |  |\\   | |  |____ |  |\\  \\");           
            System.Console.WriteLine("|__|\\ __| |_______|    |  |     |  |     |_______| |__| /__/ \\__\\    |__|      |_______/  /     \\  \\ |  |\\   | |  |\\   | |   ____ |  | \\  \\");

            //Begin App

            System.Console.WriteLine("============================================================================================================================================");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("                                            Welcome to the Netflix Show Planner!                                                            ");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("                                   Do you find yourself waisting hours watching Netflix?                                                    ");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("            With the Netflix Show Planner we'll create a custom monthly schedule for watching all your favorite shows                       ");
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("                                       Netflix Show Planner...procrastination reimagined                                                    ");
            System.Console.WriteLine("");
        

                        
                System.Console.WriteLine("                                                         |     | ");
                System.Console.WriteLine("                                                         ,-----. ");    
                System.Console.WriteLine("                                                          .___.  ");
                System.Console.WriteLine("                                                      ______|_____");
                System.Console.WriteLine("                                                     |,----------.|");
                System.Console.WriteLine("                                                     ||          ||");
                System.Console.WriteLine("                                                     ||  Netflix ||");
                System.Console.WriteLine("                                                     ||  Planner ||");
                System.Console.WriteLine("                                                     |`----------'|     ,--|=");
                System.Console.WriteLine("                                                     |o .... [###]|\\_,--'  ==");
                System.Console.WriteLine("                                                     |____________|        `---");
                
            
            //Loop this so if they say no it will say type ready to begin?
            System.Console.WriteLine("============================================================================================================================================");
            System.Console.WriteLine("                                               Are you ready to begin? Y | N "                                                               );
            System.Console.WriteLine("============================================================================================================================================");
            string response = System.Console.ReadLine();
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            
            
            //User types Y or yes
            System.Console.WriteLine("                                            Fantastic! Let's get started!                                                                   ");
            System.Console.WriteLine("                            Do you wish to see your shows that you are currently watching? Y|N                                              ");
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            //Dashboard
            System.Console.WriteLine("============================================================================================================================================");
            string showShows = System.Console.ReadLine();
            if (showShows == "yes" || showShows == "y")
            {
                System.Console.WriteLine("                            Here is a list of all the shows that your watching:                                                          ");
                System.Console.WriteLine("");
                homePage.DisplayShows();
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");        

            //Adding a show
            System.Console.WriteLine("                                       Would you like to add a show? Y|N                                                                     ");
            string addShow = System.Console.ReadLine();
            if (addShow == "yes" || addShow == "y")
            {
                System.Console.WriteLine("                   Fantastic! First we have to get some information about your show!                                                       ");
                System.Console.WriteLine("");
                System.Console.WriteLine("Enter the name of your show: ");
                string showName = System.Console.ReadLine();
                System.Console.WriteLine("");
                System.Console.WriteLine("Enter a description of your show: ");
                string showDescription = System.Console.ReadLine();
                System.Console.WriteLine("");
                System.Console.WriteLine("Enter how many episodes do you want to watch: ");
                int showEpisodes = Convert.ToInt32(System.Console.ReadLine());
                homePage.HomeScreen.Add(new Show(showName, showDescription, showEpisodes));
                
            }
            System.Console.WriteLine("");
            System.Console.WriteLine("");

            

            
                
            System.Console.WriteLine("  ______________________________________________________________");
            System.Console.WriteLine(" .'  __________________________________________________________ '.");
            System.Console.WriteLine(": .'                                                          '. :");
            System.Console.WriteLine("| |      ________________________________________________      | |");
            System.Console.WriteLine("| |    .:________________________________________________:.    | |");
            System.Console.WriteLine("| |    |                                                  |    | |");
            Calendar plan = new Calendar();
            plan.ShowSchedule(homePage);
            System.Console.WriteLine("| |    |                                                  |    | |");
            System.Console.WriteLine("| |    |                                                  |    | |");
            System.Console.WriteLine("| |    |                                                  |    | |");
            System.Console.WriteLine("| |    |                                                  |    | |");
            System.Console.WriteLine("| |    |            __________________________            |    | |");
            System.Console.WriteLine("| |    |           |  |  |  |  |  |  |  |  |  |           |    | |");
            System.Console.WriteLine("| |    '.__________|__|__|__|__|__|__|__|__|__|__________.'    | |");
            System.Console.WriteLine("| |                                                            | |");
            System.Console.WriteLine("| |                         CodingDojo                         | |");
            System.Console.WriteLine(": '.__________________________________________________________.' :");
            System.Console.WriteLine(" \".__________________________\\__/____________________________.\"");







        }
    }
}
