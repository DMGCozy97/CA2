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
        List<Activity> selectedActivities = new List<Activity>();
        List<Activity> filteredActivities = new List<Activity>();

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
            Activity sixthact = new Activity("Surfing", 25m, "2 hour surf lesson on the wild atlantic way", new DateTime(2019, 06, 02), ActivityType.Water);
            Activity seventhact = new Activity("Parachuting", 100m, "Experience the thrill of free fall while you tandem jump from an airplane.", new DateTime(2019, 06, 01), ActivityType.Air);
            Activity eigthact = new Activity("Hang Gliding", 80m, "Soar on hot air currents and enjoy spectacular views of the coastal region.", new DateTime (2019, 06,03 ), ActivityType.Air);
            Activity ninthact = new Activity("Helicopter Tour", 200m, "Experience the ultimate in aerial sight-seeing as you tour the area in our modern helicopters", new DateTime(2019, 06, 03), ActivityType.Air);


            //add to list
            allActivities.Add(firstact);
            allActivities.Add(secondact);
            allActivities.Add(thirdact);
            allActivities.Add(fourthact);
            allActivities.Add(fifthact);
            allActivities.Add(sixthact);
            allActivities.Add(seventhact);
            allActivities.Add(eigthact);
            allActivities.Add(ninthact);

            activityLbx.ItemsSource = allActivities;

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //figure which item selected
            Activity selectedActivity = activityLbx.SelectedItem as Activity;
            //null check 
            if (selectedActivity != null)
            { ////move item from left to right
                allActivities.Remove(selectedActivity);
                selectedActivities.Add(selectedActivity);

                //refresh screeen
                RefreshScreen();
            }
            
        }

        private void BtnRemove_Click(object sender, RoutedEventArgs e)
        {
             //figure which item selected
             Activity selectedActivity = lbxCart.SelectedItem as Activity;
            //null check 
            if (selectedActivity != null)
            { ////move item from left to right
                allActivities.Add(selectedActivity);
                selectedActivities.Remove(selectedActivity);

                //refresh screeen
                RefreshScreen();
            }

        }

        private void RefreshScreen()
        {
            activityLbx.ItemsSource = null;
            activityLbx.ItemsSource = allActivities;

            lbxCart.ItemsSource = null;
            lbxCart.ItemsSource = selectedActivities;
        }

        private void rbAll_Checked(object sender, RoutedEventArgs e)
        {
            filteredActivities.Clear();

            if (rbAll.IsChecked == true)
            {
                //show all activities
                RefreshScreen();
            }
            else if(rbAir.IsChecked == true)
            {
                //show air activities
                foreach(Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Air)
                    {
                        filteredActivities.Add(activity);
                        activityLbx.ItemsSource = null;
                        activityLbx.ItemsSource = filteredActivities;
                    }
                }
            }
            else if(rbLand.IsChecked == true)
            {
                //show land activites
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Land)
                    {
                        filteredActivities.Add(activity);
                        activityLbx.ItemsSource = null;
                        activityLbx.ItemsSource = filteredActivities;
                    }
                }
            }
            else if(rbWater.IsChecked == true)
            {
                //show water activities 
                foreach (Activity activity in allActivities)
                {
                    if (activity.TypeOfActivity == ActivityType.Water)
                    {
                        filteredActivities.Add(activity);
                        activityLbx.ItemsSource = null;
                        activityLbx.ItemsSource = filteredActivities;
                    }
                }
            }
        }
    }
}
