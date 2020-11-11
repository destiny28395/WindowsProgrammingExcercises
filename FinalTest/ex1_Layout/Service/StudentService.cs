﻿using Common.Model;
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
            throw new NotImplementedException();
        }

        public List<string> GetAllClasses()
        {
            return _data.Select(s => s.Class).Distinct().ToList();
        }

        public void Remove(int studentId)
        {
            throw new NotImplementedException();
        }

        public List<Student> SearchStudent(StudentSearchCriteria criteria)
        {
            // Implement filter criteria
            return _data.Where(s => (string.IsNullOrEmpty(criteria.SearchText) ||
                                    s.FirstName.Contains(criteria.SearchText) ||
                                    s.LastName.Contains(criteria.SearchText) ||
                                    s.StudentId.ToString().Contains(criteria.SearchText))
                                    && (string.IsNullOrEmpty(criteria.ClassName)
                                    || s.Class.Contains(criteria.ClassName))).ToList();
            //return _data;
        }

        public Student Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}