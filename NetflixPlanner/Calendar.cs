using System;
using System.Collections.Generic;

namespace NetflixPlanner
{
    public class Calendar
    {
        public int TotalDays;
        //public List<Show> ShowCalendar;

        //Constructor
        public Calendar()
        {
            TotalDays = 30;
        }


        //Methods
        public void ShowSchedule(Dashboard allShows)
        {
            Random rand  = new Random();
        

            //Iterate through all our shows
            for (int i = 1; i <= TotalDays; i++){
                int random = rand.Next(0, allShows.HomeScreen.Count);
                System.Console.WriteLine("| |       ______________________________________________|      | |");
                System.Console.WriteLine("       |          Day "+ i + "| Show: " + allShows.HomeScreen[random].ShowTitle);
            }

            
        }

    }
}