using Common.Model;
using Common.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace wpf_practice.Service
{
    public class StudentService : IStudentService
    {
        private List<Student> _data;
        public StudentService()
        {
            _data = LoadDataFromXml().Students;
        }

        private static Dataset LoadDataFromXml()
        {
            XmlSerializer reader = new XmlSerializer(typeof(Dataset));
            StreamReader file = new StreamReader(@"..\..\..\student_sample_data.xml");

            Dataset data = (Dataset)reader.Deserialize(file);
            file.Close();
            return data;
        }

        public Student Add(Student student)
        {
            _data.Add(student);

            return student;
        }

        public List<string> GetAllClasses()
        {
            return _data.Select(s => s.Class).Distinct().ToList();
        }

        public void RemoveStu(string studentId)
        {
            var removedStudent = _data.FirstOrDefault(s => s.StudentId == studentId);

            _data.Remove(removedStudent);
        }

        public List<Student> SearchStudent(StudentSearchCriteria criteria)
        {
            // Implement filter criteria
            return _data.Where(s => (string.IsNullOrEmpty(criteria.SearchText) ||
                                    s.FirstName.ToUpper().Contains(criteria.SearchText.ToUpper()) ||
                                    s.LastName.ToUpper().Contains(criteria.SearchText.ToUpper()) ||
                                    s.StudentId.ToString().Contains(criteria.SearchText))
                                    && (string.IsNullOrEmpty(criteria.ClassName)
                                    || s.Class.Contains(criteria.ClassName))).ToList();
            //return _data;
        }

        public Student Update(Student student)
        {
            var updateStudent = _data.FirstOrDefault(s => s.Id == student.Id);
            updateStudent.FirstName = student.FirstName;
            return updateStudent;
        }
    }
}
