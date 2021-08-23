using System;
using System.Xml;

namespace XML.Controllers
{
    public class XML_Reader
    {
        private XmlDocument _document;

        public XML_Reader()
        {
            _document = new XmlDocument();
        }

        public XmlNodeList ReadList(string path)
        {
            _document.Load(path);
            return _document.SelectNodes("/Items/Item");
        }
    }
}
