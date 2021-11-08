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
            lstFrame.Items.Add("Frame Type 1");
            lstFrame.Items.Add("Frame Type 2");
            lstFrame.Items.Add("Frame Type 3");
            // add items to lstGroupSet
            lstGroupSet.Items.Add("Group Set A");
            lstGroupSet.Items.Add("Group Set B");
            lstGroupSet.Items.Add("Group Set C");
            // add items to lstFinishingSet
            lstFinishingSet.Items.Add("Finishing Set X");
            lstFinishingSet.Items.Add("Finishing Set Y");
            lstFinishingSet.Items.Add("Finishing Set Z");
        }
        private void btnConfirmSelection_Click(object sender, RoutedEventArgs e)
        {
            //Display Selected Bike Components
            lstBike.Items.Clear(); //Empty the List Box in case there was a previous selection
            lstBike.Items.Add(lstFrame.SelectedValue.ToString());
            lstBike.Items.Add(lstGroupSet.SelectedValue.ToString());
            lstBike.Items.Add(lstFinishingSet.SelectedValue.ToString());
        }

    }
}
