using System;
using System.Collections.Generic;

namespace NetflixPlanner
{
    public class Dashboard
    {
        //Attributes
        public List<Show> HomeScreen;

        //Constructor
        public Dashboard()
        {
            HomeScreen = new List<Show>()
            {
                new Show("The Walking Dead", "Based on the comic book series written by Robert Kirkman, this gritty drama portrays life in the months and years that follow a zombie apocalypse.", 5),
                new Show("The Good Place", "When Eleanor Shellstrop finds herself in the afterlife, she's both relieved and surprised that she's made it into the Good Place. But it doesn't take long for Eleanor to realize she's there by mistake.", 5),
                new Show("Lucifer", "Based on characters created by Neil Gaiman, Sam Kieth and Mike Dringenberg, this series follows Lucifer, the original fallen angel, who has become dissatisfied with his life in hell.", 5),
                new Show("The Office", "The Office is an American mockumentary sitcom television series that depicts the everyday work lives of office employees in the Scranton, Pennsylvania branch of the fictional Dunder Mifflin Paper Company.", 5),
                new Show("Another Life", "Astronaut Niko Breckinridge is focused on searching the world for alien intelligence.", 5),
                new Show("Kingdom", "The deceased king rises and a mysterious plague begins to spread; the prince must face a new breed of enemies to unveil the evil scheme and save his people.", 5)


            };
        }

        //Methods
        public Show DisplayShows()
        {
            
                for(int i = 0; i < HomeScreen.Count; i++)
                {
                    System.Console.WriteLine("Show Name: "+ HomeScreen[i].ShowTitle);
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Show Description: " + HomeScreen[i].ShowDescription);
                    System.Console.WriteLine("________________________________________________________________________________________________________________________________________________________________________________________________________");

                }
        
            return null;

        }



    }




}