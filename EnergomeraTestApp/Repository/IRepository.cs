using EnergomeraTestApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Repository
{
    interface IRepository : IDisposable
    {
        IEnumerable<Item> GetItemsList();
        Item GetItem(int id);
        void Create(string name);
        bool Update(int id, string name);
        void Delete(int id);
        void Save();
    }
}
