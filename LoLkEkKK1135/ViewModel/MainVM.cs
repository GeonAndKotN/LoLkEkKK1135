using ConsoleApp47;
using LoLkEkKK1135.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLkEkKK1135.ViewModel
{
    public class MainVM : BaseVM
    {
        private Users users = new();
        public Users SelectedUsers
        {
            get => users;
            set
            {
                users = value;
                Signal();
            }
        }

        public MainVM()
        {
            Users = new ObservableCollection<Users>();
        }

        public ObservableCollection<Users>? Users { get; set; }

        public MainVM(ObservableCollection<Users>? users)
        {
            Users = users;
        }
    }
}
