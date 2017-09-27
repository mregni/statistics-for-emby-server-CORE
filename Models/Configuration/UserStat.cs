using System.Collections.Generic;

namespace statistics.Models.Configuration
{
    public class UserStat
    {
        public string UserName { get; set; }
        public List<ValueGroup> OverallStats { get; set; }
        public List<ValueGroup> MovieStats { get; set; }
        public List<ValueGroup> ShowStats { get; set; }
        public List<ShowProgress> ShowProgresses { get; set; }

        public UserStat()
        {
            OverallStats = new List<ValueGroup>();
            MovieStats = new List<ValueGroup>();
            ShowStats= new List<ValueGroup>();
            ShowProgresses = new List<ShowProgress>();
        }

       
    }
}
