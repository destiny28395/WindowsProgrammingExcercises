using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace _07_Exercise
{
    [XmlRoot("dataset")]
    public class Dataset
    {
        [XmlElement("Student")]
        public List<Student> Students { get; set; }
    }
}
