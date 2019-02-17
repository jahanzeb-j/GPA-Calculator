using GpaCalculator.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace GpaCalculator
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class simpleGPA : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public simpleGPA()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
       
        double grad1, grad2, grad3, grad4, grad5, grad6, grad7, grad8, grad9, grad10;
        int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10;

        private void calculateClicked(object sender, RoutedEventArgs e)
        {
            //Grade points Methods gating value 
            if (grade1.Text == "") { grad1= 0; } else { grad1 = double.Parse(grade1.Text); }
            if (grade1_Copy.Text == "") { grad2 = 0; } else { grad2 = double.Parse(grade1_Copy.Text); }
            if (grade1_Copy1.Text == "") { grad3 = 0; } else { grad3 = double.Parse(grade1_Copy1.Text); }
            if (grade1_Copy2.Text == "") { grad4 = 0; } else { grad4 = double.Parse(grade1_Copy2.Text); }
            if (grade1_Copy3.Text == "") { grad5 = 0; } else { grad5 = double.Parse(grade1_Copy3.Text); }
            if (grade1_Copy4.Text == "") { grad6 = 0; } else { grad6 = double.Parse(grade1_Copy4.Text); }
            if (grade1_Copy5.Text == "") { grad7= 0; } else { grad7= double.Parse(grade1_Copy5.Text); }
            if (grade1_Copy6.Text == "") { grad8 = 0; } else { grad8 = double.Parse(grade1_Copy6.Text); }
            if (grade1_Copy7.Text == "") { grad9 = 0; } else { grad9 = double.Parse(grade1_Copy7.Text); }
            if (grade1_Copy8.Text == "") { grad10 = 0; } else { grad10 = double.Parse(grade1_Copy8.Text); }
          
            //Credit points Methods gating value 
            if (quality1.Text == "") { num1 = 0; } else { num1 = int.Parse(quality1.Text); }
            if (quality1_Copy.Text == "") { num2 = 0; } else { num2 = int.Parse(quality1_Copy.Text); }
            if (quality1_Copy1.Text == "") { num3 = 0; } else { num3 = int.Parse(quality1_Copy1.Text); }
            if (quality1_Copy2.Text == "") { num4 = 0; } else { num4 = int.Parse(quality1_Copy2.Text); }
            if (quality1_Copy3.Text == "") { num5 = 0; } else { num5 = int.Parse(quality1_Copy3.Text); }
            if (quality1_Copy4.Text == "") { num6 = 0; } else { num6 = int.Parse(quality1_Copy4.Text); }
            if (quality1_Copy5.Text == "") { num7 = 0; } else { num7 = int.Parse(quality1_Copy5.Text); }
            if (quality1_Copy6.Text == "") { num8 = 0; } else { num8 = int.Parse(quality1_Copy6.Text); }
            if (quality1_Copy7.Text == "") { num9 = 0; } else { num9 = int.Parse(quality1_Copy7.Text); }
            if (quality1_Copy8.Text == "") { num10 = 0; } else { num10 = int.Parse(quality1_Copy8.Text); }

            double temp1 = num1 * grad1;
            double temp2 = num2 * grad2;
            double temp3 = num3 * grad3;
            double temp4 = num4 * grad4;
            double temp5 = num5 * grad5;
            double temp6 = num6 * grad6;
            double temp7 = num7 * grad7;
            double temp8 = num8 * grad8;
            double temp9 = num9 * grad9;
            double temp10 = num10 * grad10;


            double tempplus = temp1 + temp2 + temp3 + temp4 + temp5 + temp6 + temp7 + temp8 + temp9 + temp10;
            int tempAding = num1+ num2+ num3+ num4+ num5+ num6+ num7+ num8+ num9+ num10;
            float temp = (float)(tempplus / tempAding);

            gpa.Text = temp.ToString();
        
        }
    
    
    
    
    }
}
