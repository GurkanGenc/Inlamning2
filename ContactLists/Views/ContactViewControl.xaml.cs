using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContactLists.Views
{
    /// <summary>
    /// Interaction logic for ContactViewControl.xaml
    /// </summary>
    public partial class ContactViewControl : UserControl
    {
        public ContactViewControl()
        {
            InitializeComponent();
        }

        private void contactButton_Click(object sender, RoutedEventArgs e)
        {
            contactImage.Source = new BitmapImage(new Uri("/Images/Angelina_Jolie.jpg", UriKind.Relative));
            contactName.Text = "Angelina Jolie";
            occupation.Text = "Movie Star";
            email.Text = "a.jolie_1974@gmail.com";
        }

        private void contactButton2_Click(object sender, RoutedEventArgs e)
        {
            contactImage.Source = new BitmapImage(new Uri("/Images/Brad.jpg", UriKind.Relative));
            contactName.Text = "Brad Pitt";
            occupation.Text = "Movie Star";
            email.Text = "babyface@msn.com";
        }

        private void contactButton3_Click(object sender, RoutedEventArgs e)
        {
            contactImage.Source = new BitmapImage(new Uri("/Images/Jennifer.jpg", UriKind.Relative));
            contactName.Text = "Jennifer Aniston";
            occupation.Text = "Movie Star";
            email.Text = "jenny_1234@hotmail.com";
        }

        private void contactButton4_Click(object sender, RoutedEventArgs e)
        {
            contactImage.Source = new BitmapImage(new Uri("/Images/Bill_Gates.png", UriKind.Relative));
            contactName.Text = "Bill Gates";
            occupation.Text = "Retired";
            email.Text = "thebill@dot.net";
        }
    }
}
