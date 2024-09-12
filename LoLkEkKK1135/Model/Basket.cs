using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLkEkKK1135.Model
{
    [MysqlTable("Basket")]
    public class Basket
    {
        [MysqlColumn("id")]
        public int Id { get; set; }
        [MysqlColumn("UserId")]
        public int UserId { get; set; }
        [MysqlColumn("ProducktId")]
        public int ProducktId { get; set; }
    }
}
