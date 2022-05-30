using EnergomeraTestApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Commands
{
    public class DeleteCommand : ICommand
    {
        int _id;
        public DeleteCommand(int id)
        {
            _id = id;
        }
        public void Execute()
        {
            using (SQLiteItemRepository repository = new SQLiteItemRepository())
            {
                repository.Delete(_id);
                repository.Save();
                Console.WriteLine("Предмет добавлен");
            }
        }
    }
}
