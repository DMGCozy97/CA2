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

        //public decimal Cost { get; set; }
        private decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set
            {
                TotalCost += value; ;
                _cost = value;
            }
        }


        public string Description { get; set; }

        public ActivityType TypeOfActivity { get; set; }
        public object SuitableFor { get; internal set; }

        public static decimal TotalCost;


        //CONSTRUCTORS
        public Activity(string name, decimal cost, string description, DateTime activityDate, ActivityType ack)
        {
            this.Name = name;
            this.Cost = cost;
            this.Description = description;
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
