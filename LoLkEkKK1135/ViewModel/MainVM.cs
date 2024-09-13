using ConsoleApp47;
using LoLkEkKK1135.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LoLkEkKK1135.ViewModel
{
    public class MainVM : BaseVM
    {
        public static List<Users> GetUsers()
        {
            return MysqlTools.SimpleSelectFromTable<Users>();
        }

        public static List<Products> GetProducts()
        {
            return MysqlTools.SimpleSelectFromTable<Products>();
        }
    }
}
