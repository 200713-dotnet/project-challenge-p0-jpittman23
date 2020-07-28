using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace PizzaStore.Domain.Models
{
    public class FileManager
    {
        private const string _path = @"data/pizza_store.xml";
        public void Write(Order order)
        {
            var writer = new StreamWriter(_path);
            var xml = new XmlSerializer(typeof(Order));

            xml.Serialize(writer, order);
        }
        public Order Read()
        {
            var reader = new StreamReader(_path);
            var xml = new XmlSerializer(typeof(Order));

            return (Order)xml.Deserialize(reader);
        }
    }
}