using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLkEkKK1135.Model
{
    [MysqlTable("Users")]
    public class Users : BaseModel
    {
        [MysqlColumn("Name")]
        public string Name { get; set; }
        [MysqlColumn("Password")]
        public string Password { get; set; }
    }
}
