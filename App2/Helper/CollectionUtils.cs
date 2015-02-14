using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2.Helper
{
    public static class CollectionUtils
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> thisCollection)
        {
            if (thisCollection == null) return null;
            var oc = new ObservableCollection<T>();

            foreach (var item in thisCollection)
            {
                oc.Add(item);
            }

            return oc;
        }
    }
}
