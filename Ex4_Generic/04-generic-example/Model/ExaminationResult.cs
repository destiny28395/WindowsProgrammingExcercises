using System;
namespace _04_generic_example.Model
{
    public class ExaminationResult
    {
        public ExaminationResult(string name)
        {
            Name = name;
        }
        public ExaminationResult(string cname, int id)
        {
            cName = cname;
            StudentID = id;

        }
        public string Name { get; set; }
        public string cName { get; set; }
        public int StudentID { get; set; }
    }
}
