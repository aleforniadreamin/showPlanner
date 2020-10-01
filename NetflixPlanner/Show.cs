using System;
using System.Collections.Generic;

namespace NetflixPlanner
{
    //Attributes
    public class Show{
        public string ShowTitle;
        public string ShowDescription;
        public int NumberOfEpisodes;

    //Constructor
    public Show(string showTitle, string showDescription, int numberOfEpisodes) //Customer show
    {
        ShowTitle = showTitle;
        ShowDescription = showDescription;
        NumberOfEpisodes = numberOfEpisodes;
    }

    //Methods
    public virtual void ShowMeTheShow ()
    {
        System.Console.WriteLine($"Show Name: {ShowTitle} Show Description: {ShowDescription} Number of Episodes: {NumberOfEpisodes}");
    }
    



    }
}