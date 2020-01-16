using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectForm;

namespace ProjectWeb.Models
{
    public class ScoreDB : DbContext
    {
        public DbSet<Score> scoreboard { get; set; }   
    }
    public class Score
    {
        [Key]
        public int playerID { get; set; }
       [Required]
        public String login { get; set; }
        [Required]
        [CheckScore]
        public int points { get; set; }
        [Required]
        public int seconds { get; set; }
        [Required]
        [Remote("CheckValidIP","Scores")]
        public string ClientIp { get; set; }


        private class CheckScoreAttribute : ValidationAttribute
        {
            public override bool IsValid(object value)
            {
                int point = (int)value;
                if (point == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}