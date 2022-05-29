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

        public void Create(Item book)
        {
            _db.Items.Add(book);
        }

        public void Update(Item book)
        {
            _db.Entry(book).State = EntityState.Modified;
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
