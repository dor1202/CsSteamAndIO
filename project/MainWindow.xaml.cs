using project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;
using System.Xml.Serialization;

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // BeginInvoke option:
        // Steps to activate this method and not ViewModelBase.Set() in property Result:
        // add "Click="tmpFunc"" to load btn XAML and delete the "Command="{Binding Load}"". On line 31 in XAML.
        void tmpFunc(object sender, RoutedEventArgs e)
        {
            Func<List<User>> method = SerializeLoad;
            IAsyncResult userDetails = method.BeginInvoke(null, null);
            List<User> tmp = method.EndInvoke(userDetails);
            StringBuilder sb = new StringBuilder();
            tmp.ForEach(x => sb.Append($"user: {x.Id}, {x.Name}, {x.Addrress}\n"));
            res.Text = sb.ToString();
        }

        List<User> SerializeLoad()
        {
            XmlSerializer ser = new XmlSerializer(typeof(List<User>));
            using (var fs = File.OpenRead("UserDetails.xml"))
            {
                return (List<User>)ser.Deserialize(fs);
            }
        }
    }
}
