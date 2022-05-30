using EnergomeraTestApp.Data;
using EnergomeraTestApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Repository
{
    public class SQLiteItemRepository : IRepository
    {
        private ApplicationDbContext  _db;

        public SQLiteItemRepository()
        {
            _db = new ApplicationDbContext();
        }

        public IEnumerable<Item> GetItemsList()
        {
            return _db.Items;
        }

        public Item GetItem(int id)
        {
            return _db.Items.Find(id);
        }

        public void Create(string name)
        {
            Item item = new Item() { Name = name};
            _db.Items.Add(item);
        }

        public bool Update(int id,string name)
        {
           var item= _db.Items.Find(id);
            if (item == null)
                return false;
           item.Name = name;
            return true;
        }

        public void Delete(int id)
        {
            Item book = _db.Items.Find(id);
            if (book != null)
                _db.Items.Remove(book);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
