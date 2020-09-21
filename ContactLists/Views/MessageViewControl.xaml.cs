using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Net.Mail;
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
    /// Interaction logic for MessageViewControl.xaml
    /// </summary>
    public partial class MessageViewControl : UserControl
    {
        public MessageViewControl()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, RoutedEventArgs e)
        {
            time.Text = DateTime.Now.ToString();
            subject.Text = "Have you seen Brad??";
            from.Text = "Angelina Jolie";
            to.Text = "a.jolie1974@gmail.com";
            body.Text = "Vestibulum interdum eros sed congue pellentesque. Ut ac purus nec leo efficitur imperdiet ut vel est. Praesent consequat turpis id turpis rhoncus condimentum. Nam quis vehicula purus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Mauris volutpat lacus sed felis convallis scelerisque. Vestibulum aliquam finibus ultricies. Praesent eleifend porta metus, nec laoreet mauris vulputate et. Vestibulum tincidunt nulla ac quam facilisis congue.";
        }
    }
}
