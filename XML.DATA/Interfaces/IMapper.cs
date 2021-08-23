using System;
using System.Xml;

namespace XML.DATA
{
    public interface IMapper<T>
    {
        public T Map();
        public void SetNode(XmlNode node);
    }
}
