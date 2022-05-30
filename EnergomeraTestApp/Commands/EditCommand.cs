using EnergomeraTestApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Commands
{
    public class EditCommand : ICommand
    {
        int _id;
        string _name;
        public EditCommand(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public void Execute()
        {
            using (SQLiteItemRepository repository = new SQLiteItemRepository())
            {
                if (!repository.Update(_id, _name))
                {
                    Console.WriteLine("Предмет отсутствует");
                    return;
                }
                repository.Save();
                Console.WriteLine("Предмет изменён");
            }
        }
    }
}
