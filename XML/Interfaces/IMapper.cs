using System;
using System.Collections.Generic;

namespace XML.Interfaces
{
    public interface IMapper<T>
    {
        public T Map();
    }
}
