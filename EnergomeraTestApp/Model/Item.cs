using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Model
{
    [Table("Items")]
    public class Item
    {

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
