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
            to.Text = "a.jolie_1974@gmail.com";
            body.Text = "Vestibulum interdum eros sed congue pellentesque. Ut ac purus nec leo efficitur imperdiet ut vel est. Praesent consequat turpis id turpis rhoncus condimentum. Nam quis vehicula purus. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Mauris volutpat lacus sed felis convallis scelerisque. Vestibulum aliquam finibus ultricies. Praesent eleifend porta metus, nec laoreet mauris vulputate et. Vestibulum tincidunt nulla ac quam facilisis congue.";
        }

        private void messageButton2_Click(object sender, RoutedEventArgs e)
        {
            time.Text = DateTime.Now.ToString();
            subject.Text = "Don\'t tell Angie nothing!!";
            from.Text = "Brad Pitt";
            to.Text = "babyface@msn.com";
            body.Text = "Mauris scelerisque, ligula vitae rhoncus consectetur, nibh risus posuere est, vel posuere nibh elit ac magna. Ut lobortis ipsum sem. In aliquet nibh ac felis eleifend dapibus. In sit amet tincidunt risus. Maecenas luctus est non mi sodales efficitur. Fusce nec est.";
        }

        private void messageButton3_Click(object sender, RoutedEventArgs e)
        {   
            time.Text = DateTime.Now.ToString();
            subject.Text = "Where are my vaccines?!";
            from.Text = "Bill Gates";
            to.Text = "thebill@dot.net";
            body.Text = "Mauris egestas bibendum lectus. Cras vehicula metus dolor, at porta lacus fermentum id. Suspendisse tempor nibh sit amet mi finibus, id dapibus lorem luctus. Ut tempus dignissim arcu, ac hendrerit erat efficitur et. Ut tortor odio, maximus vel est vel, interdum egestas augue. Proin sed magna a magna volutpat blandit eu eu libero. Phasellus at hendrerit nulla. Aenean pretium libero purus, vehicula mattis urna venenatis non. Nullam quis felis eros. Aenean sit amet rhoncus quam, at mollis sapien.Aenean hendrerit finibus ante in molestie.Vestibulum tellus sem, lobortis et tellus ut, iaculis placerat tellus. Maecenas sit amet nibh at mauris elementum convallis. Aliquam erat volutpat.Proin eu libero metus. Cras tincidunt ex sed velit hendrerit, ullamcorper tristique enim fringilla.Sed sagittis rhoncus est.";
        }

        private void messageButton4_Click(object sender, RoutedEventArgs e)
        {
            time.Text = DateTime.Now.ToString();
            subject.Text = "I need to speak with Brad. Urgent!";
            from.Text = "Jennifer Aniston";
            to.Text = "jenny_1234@hotmail.com";
            body.Text = "Aenean velit nibh, sagittis sit amet maximus et, tristique quis est. Vestibulum quis congue dolor. Praesent vitae odio sed ex mattis blandit id vel lorem. Sed dignissim.";
        }
    }
}
