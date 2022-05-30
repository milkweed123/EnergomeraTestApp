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
                if (repository.Delete(_id))
                {
                    Console.WriteLine("Предмет удален");
                    repository.Save();
                }
                else
                {
                    Console.WriteLine("Предмет с таким идентификатором отсутствует");
                    return;
                }
            }
        }
    }
}
