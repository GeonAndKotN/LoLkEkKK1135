using LoLkEkKK1135.Model;
using System;
using System.Collections.Generic;
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
    }
}
