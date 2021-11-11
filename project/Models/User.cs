using System.Xml.Serialization;

namespace project.Models
{
    public class User
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Addrress { get; set; }
    }
}
