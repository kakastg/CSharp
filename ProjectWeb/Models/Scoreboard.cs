using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectForm;

namespace ProjectWeb.Models
{
    public class Scoreboard
    {
        public static int ScoreNum = 0;
        public int aukcjaID { get; set; }

        public Scoreboard(String login, int score, int duration, bool isMaxInterval)
        {


        }
    }
}