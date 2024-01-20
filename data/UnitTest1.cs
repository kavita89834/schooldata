using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using schooldata;
using System;
using Assert = NUnit.Framework.Assert;

namespace SchoolUnitTest
{
    [TestFixture]
    public class SchoolTest
    {
        [Test]
        public void AddStudent()
        {
            var schoolManagement = new school();
            var student = new student { StudentId = 1, StudentName = "Ram", Class = "Class 10" };

            // Act
            schoolManagement.AddStudent(student);

            // Assert
            Assert.Contains(student, schoolManagement.Students);
        }
        [Test]
        public void AddTeacher()
        {
            var schoolManagement = new school();
            var teacher = new teacher { TeacherId = 1, TeacherName = "Ravi" };

            // Act
            schoolManagement.AddTeacher(teacher);

            // Assert
            Assert.Contains(teacher, schoolManagement.Teachers);
        }
        [Test]
        public void AddSubject()
        {
            var schoolManagement = new school();
            var subject = new subject { SubjectId = 1, SubjectName = "English" };

            // Act
            schoolManagement.AddSubject(subject);

            // Assert
            Assert.Contains(subject, schoolManagement.Subjects);
        }
        [Test]
        public void StudentDataMockTest()
        {
            var schoolManagement = new school();
            var studentMock = new Mock<student>();
            studentMock.SetupGet(s => s.StudentId).Returns(1);
            studentMock.SetupGet(s => s.StudentName).Returns("Ananth");
            studentMock.SetupGet(s => s.Class).Returns("Class 10");

            // Act
            schoolManagement.AddStudent(studentMock.Object);

            // Assert
            Assert.Contains(studentMock.Object, schoolManagement.Students);
        }
        [Test]
        public void TeacherDataMockTest()
        {
            var schoolManagement = new school();
            var teacherMock = new Mock<teacher>();
            teacherMock.SetupGet(s => s.TeacherId).Returns(1);
            teacherMock.SetupGet(s => s.TeacherName).Returns("Prakash");


            // Act
            schoolManagement.AddTeacher(teacherMock.Object);

            // Assert
            Assert.Contains(teacherMock.Object, schoolManagement.Teachers);
        }
        [Test]
        public void SubjectDataMockTest()
        {
            var schoolManagement = new school();
            var subjectMock = new Mock<subject>();
            subjectMock.SetupGet(s => s.SubjectId).Returns(1);
            subjectMock.SetupGet(s => s.SubjectName).Returns("English");


            // Act
            schoolManagement.AddSubject(subjectMock.Object);

            // Assert
            Assert.Contains(subjectMock.Object, schoolManagement.Subjects);
        }
    }
}