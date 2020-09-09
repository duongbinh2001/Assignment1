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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App2
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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            string email = Email.Text;
            TxtBlock.Text += email + "\n";
            Email.Text = "";

            string content = Content.Text;
            TxtBlock.Text += content + "\n";
            Email.Text = "";

            string title = Title.Text;
            TxtBlock.Text += title + "\n";
            Title.Text = "";

        }

        private void Email_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
