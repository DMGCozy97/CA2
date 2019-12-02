using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Activity> allActivities = new List<Activity>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ActivityLbx_Loaded(object sender, RoutedEventArgs e)
        {
            //create activity objects
            Activity firstact = new Activity("Sailing",50m, "Full day lakeland kayak with island picnic.",new DateTime(2019, 06, 03), ActivityType.Water);
            Activity secondact = new Activity("Kayaking", 40m, "Half day lakeland kayak with island picnic." , new DateTime(2019, 06, 01), ActivityType.Water);
            Activity thirdact = new Activity("Treking",20m, "Instructor led group trek through local mountains.",new DateTime(2019, 06, 01), ActivityType.Land);
            Activity fourthact = new Activity("Mountain Biking",30m, "Instructor led half day mountain biking. All equipment provided.",new DateTime(2019, 06, 02), ActivityType.Land);
            Activity fifthact = new Activity("Abseiling",30m, "Experience the rush of adrenaline as you descend cliff faces from 10-500m.",new DateTime( 2019, 06, 03), ActivityType.Land);
            Activity sixthact = new Activity("Surfing", 25m, "Surf", new DateTime(2019, 06, 02), ActivityType.Water));
            Activity seventhact = new Activity("Parachuting", 100m, "Para", new DateTime(2019, 06, 01), ActivityType.Air);
            Activity eigthact = new Activity("Hang Gliding", 80m, "Class", new DateTime (2019, 06,03 ), ActivityType.Air);
            //Activity ninthact = new Activity("")


            //add to list
            allActivities.Add(firstact);
            allActivities.Add(secondact);
            allActivities.Add(thirdact);
            allActivities.Add(fourthact);
            allActivities.Add(fifthact);
            allActivities.Add(sixthact);

        }
    }
}
