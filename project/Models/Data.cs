using System.IO;
using System.Xml.Serialization;

namespace project.Models
{
    class Data
    {
        public void Save<T>(T item)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (var fs = File.OpenWrite("UserDetails.xml"))
            {
                ser.Serialize(fs, item);
            }
        }

        public T Load<T>()
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (var fs = File.OpenRead("UserDetails.xml"))
            {
                return (T)ser.Deserialize(fs);
            }
        }
    }
}
