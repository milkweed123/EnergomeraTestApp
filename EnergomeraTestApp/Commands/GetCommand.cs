using EnergomeraTestApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Commands
{
    public class GetCommand : ICommand
    {
        public void Execute()
        {
            using (SQLiteItemRepository repository = new SQLiteItemRepository())
            {
                var items = repository.GetItemsList();
                foreach (var item in items)
                    Console.WriteLine(item.Id.ToString() + " " + item.Name);
            }
        }
    }
}
