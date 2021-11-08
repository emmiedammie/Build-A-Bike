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

namespace Build_A_Bike
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // add items to lstFrame
            lstFrame.Items.Add("Frame Type 1: £200");
            lstFrame.Items.Add("Frame Type 2: £210");
            lstFrame.Items.Add("Frame Type 3: £220");
            // add items to lstGroupSet
            lstGroupSet.Items.Add("Group Set A: £100");
            lstGroupSet.Items.Add("Group Set B: £110");
            lstGroupSet.Items.Add("Group Set C: £120");
            // add items to lstFinishingSet
            lstFinishingSet.Items.Add("Finishing Set X: £150");
            lstFinishingSet.Items.Add("Finishing Set Y: £160");
            lstFinishingSet.Items.Add("Finishing Set Z: £170");
        }
        private void btnConfirmSelection_Click(object sender, RoutedEventArgs e)
        {
            //Display Selected Bike Components
            lstBike.Items.Clear(); //Empty the List Box in case there was a previous selection

            lstBike.Items.Add(lstFrame.SelectedValue.ToString());
            lstBike.Items.Add(lstGroupSet.SelectedValue.ToString());
            lstBike.Items.Add(lstFinishingSet.SelectedValue.ToString());

            // Calculate Total Bike Cost
            // get cost of frame
            string frameText = lstFrame.SelectedValue.ToString();
            string[] frameArray = frameText.Split('£');
            Decimal frameCost = Convert.ToDecimal(frameArray[1]);
            // get cost of Group Set
            string groupSetText = lstGroupSet.SelectedValue.ToString();
            string[] groupSetArray = groupSetText.Split('£');
            Decimal groupSetCost = Convert.ToDecimal(groupSetArray[1]);
            // get cost of Finishing Set
            string finishingSetText = lstFinishingSet.SelectedValue.ToString();
            string[] finishingSetArray = finishingSetText.Split('£');
            Decimal finishingSetCost = Convert.ToDecimal(finishingSetArray[1]);
            //calculate total cost and display in lblTotalCost
            Decimal totalCost = frameCost + groupSetCost + finishingSetCost;
            lblTotalCost.Content = totalCost.ToString();
        }

    }

}
}
