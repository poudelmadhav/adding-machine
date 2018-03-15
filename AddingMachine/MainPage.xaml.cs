using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AddingMachine
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                float a, b, sum;
                a = float.Parse(numBox1.Text);
                b = float.Parse(numBox2.Text);
                sum = a + b;
                outputBlock.Text = "The sum is: " + sum.ToString();
                //outputBlock.Text = (float.Parse(numBox1.Text) + float.Parse(numBox2.Text)).ToString();
            }
            catch (Exception)
            {
                outputBlock.Text = "Please enter a valid number";
            }
        }

        async private void infoBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageDialog msg = new MessageDialog("You are awesome", "Madhav");
            await msg.ShowAsync();
        }
    }
}
