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


        private decimal _cost;

        public decimal Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }


        private string _description;

        public string Description
        {
            get {
                return Cost;
            }
            set { _description = value; }
        }


        
        DateTime ActivityDate;
        ActivityType TypeOfActivity;

        public int CompareTo(Activity other)
        {
            throw new NotImplementedException();
        }
        
        public Activity(string Name, decimal Cost, string Description, DateTime ActivityDate, ActivityType ack)
        {
            this.Name = Name;
            this.Cost = Cost;
            this.Description = Description;
            this.ActivityDate = ActivityDate;
            this.TypeOfActivity = ack;
        }
        public override string ToString()
        {

            return string.Format(Name +""+ ActivityDate.ToShortDateString());
        }
    }
}
