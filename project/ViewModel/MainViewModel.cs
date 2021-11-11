using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using project.Models;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace project.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        Data data = new Data();

        public User CurrentUser { get; set; }
        public List<User> users { get; set; }
        public RelayCommand Load { get; set; }
        public RelayCommand Save { get; set; }

        // I created 2 ways to load, Watch MainWindow.xaml.cs
        string result;
        public string Result
        {
            get { return result; }
            set { Set(ref result, value); }
        }

        public MainViewModel()
        {
            // For starting the xml file with data:

            //List<User> tmp = new List<User> { new User() { Id = 1, Addrress = "TelAviv", Name = "Dor" },
            //                                  new User() { Id = 2, Addrress = "RamatGan", Name = "Or"} };
            //users = tmp;
            //SaveMethod();
            // * when starting the xml file note lines 44 and 45.

            CurrentUser = new User();
            users = new List<User>();

            Load = new RelayCommand(LoadMethodThread);
            Save = new RelayCommand(SaveMethodThread);
        }

        void SaveMethodThread()
        {
            Thread t = new Thread(new ThreadStart(SaveMethod));
            t.Start();
        }

        void SaveMethod()
        {
            users = data.Load<List<User>>();
            users.Add(CurrentUser);
            data.Save<List<User>>(users);
            Thread.Sleep(5000);
        }

        void LoadMethodThread()
        {
            Thread t = new Thread(new ThreadStart(LoadMethod));
            t.Start();
        }

        void LoadMethod()
        {
            var a = this;
            users = data.Load<List<User>>();
            StringBuilder sb = new StringBuilder();
            users.ForEach(x => sb.Append($"user: {x.Id}, {x.Name}, {x.Addrress}\n"));
            Result = sb.ToString();
            Thread.Sleep(2000);
        }
    }
}