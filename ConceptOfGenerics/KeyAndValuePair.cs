using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptOfGenerics
{
    public class KeyAndValuePair<TKey, TValue>
    {
        public TKey Id { get; set; }
        public TValue Name { get; set; }
        public DateOnly BirthDate { get; set; }
    }
}
