using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Faculty
{
    class Faculty
    {
        private string facultyId;

        public string FacultyId { get; set; }
        private string facultyName;

        public string FacultyName
        {
            get { return facultyName; }
            set { facultyName = value; }
        }
        public Faculty()
        {

        }
        public Faculty(string facultyName, string facultyId)
        {
            this.facultyName = facultyName;
            this.facultyId = facultyId;

        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + facultyName);
            Console.WriteLine("Id: " + facultyId);
        }
    }
}
