using EnergomeraTestApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Commands
{
    public class AddCommand : ICommand
    {
        string _name;
        public AddCommand(string mame)
        {
            _name = mame;
        }

        public void Execute()
        {
            using (SQLiteItemRepository repository = new SQLiteItemRepository())
            {
                repository.Create(_name);
                repository.Save();
                Console.WriteLine("Предмет добавлен");
            }
        }
    }
}
