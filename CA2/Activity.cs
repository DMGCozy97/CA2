using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2 
{
    

    //creating enum
    public enum ActivityType { Air, Water, Land}
    public class Activity : IComparable <Activity>
    {
        //properties
        public string Name { get; set; }

        public DateTime ActivityDate { get; set; }

        public decimal Cost { get; set; }

        public string Description { get; set; }

        public ActivityType TypeOfActivity { get; set; }

        
        //CONSTRUCTORS
        public Activity(string Name, decimal Cost, string Description, DateTime activityDate, ActivityType ack)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Description = Description;
            this.ActivityDate = activityDate;
            this.TypeOfActivity = ack;
        }


        //METHODS
        public override string ToString()
        {
            return string.Format(Name + " " + ActivityDate.ToShortDateString());
        }

        public int CompareTo(Activity other)
        {
            return this.ActivityDate.CompareTo(other.ActivityDate);
        }
    }
}
