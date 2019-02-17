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
    public sealed partial class GpaCalculator_marks : Page
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


        public GpaCalculator_marks()
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
        int t1 = 0, t2 = 0, t3 = 0, t4 = 0, t5 = 0, t6 = 0, t7 = 0, t8 = 0, t9 = 0, t10 = 0, t11 = 0, t12 = 0, t13 = 0, t14 = 0;
        static double grad;
        int num1, num2, num3, num4, num5, num6, num7, num8, num9, num10, num11, num12, num13, num14;









        private void ComboChanged1(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb1.SelectedIndex == 0)
                t1 = 3;
            if (cb1.SelectedIndex == 1)
                t1 = 1;
        }

        private void ComboChanged2(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb2.SelectedIndex == 0)
                t2 = 3;
            if (cb2.SelectedIndex == 1)
                t2 = 1;
        }

        private void ComboChanged3(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb3.SelectedIndex == 0)
                t3 = 3;
            if (cb3.SelectedIndex == 1)
                t3 = 1;
        }

        private void ComboChanged4(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb4.SelectedIndex == 0)
                t4 = 3;
            if (cb4.SelectedIndex == 1)
                t4 = 1;
        }

        private void ComboChanged5(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb5.SelectedIndex == 0)
                t5 = 3;
            if (cb5.SelectedIndex == 1)
                t5 = 1;
        }

        private void ComboChanged6(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb6.SelectedIndex == 0)
                t6 = 3;
            if (cb6.SelectedIndex == 1)
                t6 = 1;
        }

        private void ComboChanged7(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb7.SelectedIndex == 0)
                t7 = 3;
            if (cb7.SelectedIndex == 1)
                t7 = 1;
        }

        private void ComboChanged8(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb8.SelectedIndex == 0)
                t8 = 3;
            if (cb8.SelectedIndex == 1)
                t8 = 1;
        }

        private void ComboChanged9(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb9.SelectedIndex == 0)
                t9 = 3;
            if (cb9.SelectedIndex == 1)
                t9 = 1;
        }

        private void ComboChanged10(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb10.SelectedIndex == 0)
                t10 = 3;
            if (cb10.SelectedIndex == 1)
                t10 = 1;
        }

        private void ComboChanged11(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb11.SelectedIndex == 0)
                t11 = 3;
            if (cb11.SelectedIndex == 1)
                t11 = 1;
        }

        private void ComboChanged12(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb12.SelectedIndex == 0)
                t12 = 3;
            if (cb12.SelectedIndex == 1)
                t12 = 1;
        }

        private void ComboChanged13(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb13.SelectedIndex == 0)
                t13 = 3;
            if (cb13.SelectedIndex == 1)
                t13 = 1;
        }

        private void ComboChanged14(FrameworkElement sender, DataContextChangedEventArgs args)
        {

            if (cb14.SelectedIndex == 0)
                t14 = 3;
            if (cb14.SelectedIndex == 1)
                t14 = 1;
        }

        private void calculateClicked(object sender, RoutedEventArgs e)
        {   //combo box selection
            if (cb1.SelectedIndex == 0)
                t1 = 3;
            if (cb1.SelectedIndex == 1)
                t1 = 1;
            if (cb2.SelectedIndex == 0)
                t2 = 3;
            if (cb2.SelectedIndex == 1)
                t2 = 1;

            if (cb3.SelectedIndex == 0)
                t3 = 3;
            if (cb3.SelectedIndex == 1)
                t3 = 1;
            if (cb4.SelectedIndex == 0)
                t4 = 3;
            if (cb4.SelectedIndex == 1)
                t4 = 1;
            if (cb5.SelectedIndex == 0)
                t5 = 3;
            if (cb5.SelectedIndex == 1)
                t5 = 1;
            if (cb6.SelectedIndex == 0)
                t6 = 3;
            if (cb6.SelectedIndex == 1)
                t6 = 1;
            if (cb7.SelectedIndex == 0)
                t7 = 3;
            if (cb7.SelectedIndex == 1)
                t7 = 1;
            if (cb8.SelectedIndex == 0)
                t8 = 3;
            if (cb8.SelectedIndex == 1)
                t8 = 1;

            if (cb9.SelectedIndex == 0)
                t9 = 3;
            if (cb9.SelectedIndex == 1)
                t9 = 1;

            if (cb10.SelectedIndex == 0)
                t10 = 3;
            if (cb10.SelectedIndex == 1)
                t10 = 1;
            if (cb11.SelectedIndex == 0)
                t11 = 3;
            if (cb11.SelectedIndex == 1)
                t11 = 1;
            if (cb12.SelectedIndex == 0)
                t12 = 3;
            if (cb12.SelectedIndex == 1)
                t12 = 1;
            if (cb13.SelectedIndex == 0)
                t13 = 3;
            if (cb13.SelectedIndex == 1)
                t13 = 1;

            if (cb14.SelectedIndex == 0)
                t14 = 3;
            if (cb14.SelectedIndex == 1)
                t14 = 1;

            //TextBox Methods gating value 
            if (m1.Text == "") { num1 = 0; } else { num1 = int.Parse(m1.Text); }
            if (m2.Text == "") { num2 = 0; } else { num2 = int.Parse(m2.Text); }
            if (m3.Text == "") { num3 = 0; } else { num3 = int.Parse(m3.Text); }
            if (m4.Text == "") { num4 = 0; } else { num4 = int.Parse(m4.Text); }
            if (m5.Text == "") { num5 = 0; } else { num5 = int.Parse(m5.Text); }
            if (m6.Text == "") { num6 = 0; } else { num6 = int.Parse(m6.Text); }
            if (m7.Text == "") { num7 = 0; } else { num7 = int.Parse(m7.Text); }
            if (m8.Text == "") { num8 = 0; } else { num8 = int.Parse(m8.Text); }
            if (m9.Text == "") { num9 = 0; } else { num9 = int.Parse(m9.Text); }
            if (m10.Text == "") { num10 = 0; } else { num10 = int.Parse(m10.Text); }
            if (m11.Text == "") { num11 = 0; } else { num11 = int.Parse(m11.Text); }
            if (m12.Text == "") { num12 = 0; } else { num12 = int.Parse(m12.Text); }
            if (m13.Text == "") { num13 = 0; } else { num13 = int.Parse(m13.Text); }
            if (m14.Text == "") { num14 = 0; } else { num14 = int.Parse(m14.Text); }


            /*
                        num1 = int.Parse(m1.Text);
                        num2 = int.Parse(m2.Text);
                        num3 = int.Parse(m3.Text);
                        num4 = int.Parse(m4.Text);
                        num5 = int.Parse(m5.Text);
                        num6 = int.Parse(m6.Text);
                        num7 = int.Parse(m7.Text);
                        num8 = int.Parse(m8.Text);
                        num9 = int.Parse(m9.Text);
                        num10 = int.Parse(m10.Text);
                        num11 = int.Parse(m11.Text);
                        num12 = int.Parse(m12.Text);
                        num13 = int.Parse(m13.Text);
                        num14 = int.Parse(m14.Text);
                        */
            //operation
            grades(num1, t1);
            double temp1 = t1 * grad;
            grades(num2, t2);
            double temp2 = t2 * grad;
            grades(num3, t3);
            double temp3 = t3 * grad;
            grades(num4, t4);
            double temp4 = t4 * grad;
            grades(num5, t5);

            double temp5 = t5 * grad;
            grades(num6, t6);

            double temp6 = t6 * grad;
            grades(num7, t7);
            double temp7 = t7 * grad;
            grades(num8, t8);
            double temp8 = t8 * grad;
            grades(num9, t9);
            double temp9 = t9 * grad;
            grades(num10, t10);
            double temp10 = t10 * grad;
            grades(num11, t11);
            double temp11 = t11 * grad;
            grades(num12, t12);
            double temp12 = t12 * grad;
            grades(num13, t13);
            double temp13 = t13 * grad;
            grades(num14, t14);
            double temp14 = t14 * grad;



            //if condition
            if (num1 == 0)
            {
                temp1 = 0;
                t1 = 0;
            }
            if (num2 == 0)
            {
                temp2 = 0; t2 = 0;
            }
            if (num3 == 0)
            {
                temp3 = 0; t3 = 0;
            }
            if (num4 == 0)
            {
                temp4 = 0; t4 = 0;
            }
            if (num5 == 0)
            {
                temp5 = 0; t5 = 0;
            }
            if (num6 == 0)
            {
                temp6 = 0; t6 = 0;
            }
            if (num7 == 0)
            {
                temp7 = 0; t7 = 0;
            }
            if (num8 == 0)
            {
                temp8 = 0; t8 = 0;
            }
            if (num9 == 0)
            {
                temp9 = 0; t9 = 0;
            }
            if (num10 == 0)
            {
                temp10 = 0; t10 = 0;
            }

            double tempplus = temp1 + temp2 + temp3 + temp4 + temp5 + temp6 + temp7 + temp8 + temp9 + temp10 + temp11 + temp12 + temp13 + temp14;
            int tempAding = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10 + t11 + t12 + t13 + t14;
            float temp = (float)(tempplus / tempAding);

            gpa.Text = temp.ToString();


        }
        public void grades(int n, int t)
        {
            if (t == 3)
            {
                if (n >= 85)
                    grad = 4;
                else if (n >= 80)
                    grad = 3.75;
                else if (n >= 75)
                    grad = 3.5;
                else if (n >= 70)
                    grad = 3;
                else if (n >= 65)
                    grad = 2.5;
                else if (n >= 60)
                    grad = 2;
                else if (n >= 55)
                    grad = 1.5;
                else if (n >= 50)
                    grad = 1;
                else if (n >= 0)
                    grad = 0;

            }
            //50 marks
            else if (t == 1)
            {
                if (n > 50)
                    grad = 0;
                else if (n >= 42 && n<=50)
                    grad = 4;
                else if (n >= 40)
                    grad = 3.75;
                else if (n >= 37)
                    grad = 3.50;
                else if (n >= 35)
                    grad = 3.00;
                else if (n >= 32)
                    grad = 2.50;
                else if (n >= 30)
                    grad = 2.00;
                else if (n >= 27)
                    grad = 1.5;
                else if (n >= 25)
                    grad = 1;
                else if (n >= 0)
                    grad = 0;
                else if (n > 50)
                    grad = 0;

                // return grad;
            }
        }
    }
}
