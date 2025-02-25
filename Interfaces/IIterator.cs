using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosProject.Interfaces
{
    public interface IIterator
    {
        public bool HasNext();
        public int Next();
        
    }
}
