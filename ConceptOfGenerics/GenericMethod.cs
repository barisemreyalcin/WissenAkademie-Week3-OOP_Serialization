using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConceptOfGenerics
{
    public class GenericMethod<T>
    {
        public T[] arr = new T[5];

        public void addData(int index, T data) {
            if (index >= 0 && index < 5 && data != null)
            {
                arr[index] = data;
            }
        }

        public void addData(T index, T data)
        {
           // diziye eklenecek datalar
        }

        public void addData(T data)
        {
            // diziye eklenecek datalar
        }

        public T GetData(int index) {
            if (index >= 0 && index < 5)
                return arr[index];
            else 
                return default(T); // belirlenmiş olan tipin default değeri döndürülür
        }
    }
}
