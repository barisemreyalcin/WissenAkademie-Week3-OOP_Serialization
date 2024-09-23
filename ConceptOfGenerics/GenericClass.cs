using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptOfGenerics
{
    public class GenericClass<T> // bu class bu tipte bir type safety sağlar.
    {
        public T Id { get; set; }
        public string FirstName{ get; set; }
        public string LastName { get; set; }
    }
}
