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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_Tetris
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class titlepage : Page
    {
        public titlepage()
        {
            this.InitializeComponent();
            dontworrybox.Text = String.Empty;
        }

        private void playbutton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void playbutton_PointerMoved(object sender, PointerRoutedEventArgs e)
        {
            playbutton.Content = "OH YEAH";
            dontworrybox.Text = "Don't worry, button is still clickable";
            //for some reason the play button just disappears but the button is still clickable
        }

        private void playbutton_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            playbutton.Content = "GET TO PRAYIN'";
            dontworrybox.Text = String.Empty;
        }
    }
}
