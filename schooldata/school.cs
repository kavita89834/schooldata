using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace schooldata
{
    public class school
    {
        private List<student> students = new List<student>();
        private List<teacher> teachers = new List<teacher>();
        private List<subject> subjects = new List<subject>();

        public List<student> Students
        {
            get { return students; }
            private set { students = value; }
        }

        public List<teacher> Teachers
        {
            get { return teachers; }
            private set { teachers = value; }
        }

        public List<subject> Subjects
        {
            get { return subjects; }
            private set { subjects = value; }
        }



        public void AddStudent(student student)
        {
            students.Add(student);
        }
        public void AddTeacher(teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddSubject(subject subject)
        {
            subjects.Add(subject);
        }
    }
}
   
