using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Faculty
{
    class Department
    {
        public string DepartmentName { get; set; }
        public string DepartmentNumber { get; set; }
        public int totalFaculty { get; set; }
        public Faculty[] listOfFaculty;
        private int facultyCount;
        public int FacultyCount
        {
            get { return facultyCount; }
            set { facultyCount = value; }
        }

        public Department()
        {
            listOfFaculty = new Faculty[100];
            facultyCount = 0;
        }
        public Department(string name, string number)
        {
            DepartmentName = name;
            DepartmentNumber = number;
            listOfFaculty = new Faculty[100];
            facultyCount = 0;

        }
        public void Show()
        {
            Console.WriteLine("Name Of The Department: " + DepartmentName);
            Console.WriteLine("ID Number Of The Department: " + DepartmentNumber);
            Console.WriteLine("Total Number Of Faculty: " + totalFaculty);
        }
        public void AddFaculty(params Faculty[] faculties)
        {
            foreach (var faculty in faculties)
            {
                if (facultyCount< 100)
                  listOfFaculty[facultyCount++] = faculty;
                
            }
        }
        public Faculty SearchFaculty(string fid)
        {
            Faculty f = null;
            for (int i = 0; i < facultyCount; i++)
            {
                if (listOfFaculty[i].FacultyId.Equals(fid))
                {
                    f = listOfFaculty[i];
                    break;
                }
            }
            return f;
        }
        public void RemoveFaculty(Faculty faculty)
        {
            for (int i = 0; i < facultyCount; i++)
            {
                if (faculty.FacultyId.Equals(listOfFaculty[i].FacultyId))
                {
                    for (int j = i; j <facultyCount- 1; j++)
                    {
                        listOfFaculty[j] = listOfFaculty[j + 1];
                    }
                    facultyCount--;
                    break;
                }

            }
        }
        public void ShowAllFaculty()
        {
            for (int i = 0; i < facultyCount; i++)
            {
                listOfFaculty[i].ShowInfo();

            }
        }


    }
    }
