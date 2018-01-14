using Domain.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class DB<T> : IEnumerable<T> where T:EntitiyBase,IAuditable,IValidatable 
    {
        private List<T> items { get; set; }

        public DB()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            
            item.SetAuditCreationInfo(Environment.UserName);
            items.Add(item);
        }

        public void Delete(T item)
        {
            items.Remove(item);
        }

        public void Upsert(T item)
        {
            bool exsist = false;
            foreach (T itemIt in items)
            {
                if (itemIt.Equals(item))
                {
                    exsist = true;
                    items.Remove(item);
                    items.Add(item);
                }
            }
            if (exsist == false)
            {
                items.Add(item);
            }
        }

        public int Count()
        {
            return items.Count();
        }

        public IEnumerator GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return items.GetEnumerator();
        }


        public bool ValidateAll()
        {
            foreach (var item in items)
            {
                if (!item.Validate())
                {
                    return false;
                }
            }

            return true;
        }
    }
}
