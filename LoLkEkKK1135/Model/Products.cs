using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoLkEkKK1135.Model
{
    [MysqlTable("Products")]
    public class Products
    {
        [MysqlColumn("id")]
        public int Id { get; set; }
        [MysqlColumn("Title")]
        public string Title { get; set; }
        [MysqlColumn("Price")]
        public double Price { get; set; }
        [MysqlColumn("Count")]
        public int Count { get; set; }
    }
}
