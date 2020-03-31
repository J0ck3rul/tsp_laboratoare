using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Database<T> where T : class
    {
        private Model1Container context;
        private DbSet<T> table;
        public Database()
        {
            context = new Model1Container();
            table = context.Set<T>();
        }
        public IReadOnlyList<T> GetAll()
        {
            return table.ToList().AsReadOnly();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Insert(T model)
        {
            table.Add(model);
            context.SaveChanges();
        }

        public void Update(T model, int id)
        {
            var entity = table.Find(id);
            context.Entry(entity).CurrentValues.SetValues(model);

            SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = this.GetById(id);
            table.Remove(entity);
            SaveChanges();
        }

        private void SaveChanges()
        {
            context.SaveChanges();
        }
    }
}
