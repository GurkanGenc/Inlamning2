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
            DataContext = new ContactViewControl();
        }
    }
}
