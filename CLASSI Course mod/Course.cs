using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASSI_Course_mod
{
    internal class Course
    {
        string CourseName;
        string InstructorName;
        int Duration;
        List<string> names = new List<string>();

        public Course(string CourseName, string InstructorName, int Duration)
        {
            this.CourseName = CourseName;
            this.InstructorName = InstructorName;
            this.Duration = Duration;
        }

        public void AddSubscriber(string Subscriber)
        {
            names.Add(Subscriber);
        }

        public bool RemoveSubsciber(string Subscriber)
        {
            return names.Remove(Subscriber);
        }

        public int NumberOfSubscribers()
        {
            return names.Count;
        }

        public string GetSubscribers(int i)
        {
            return names[i];
        }

        public int Compare(string CourseName, int i)
        {
            int found = -1;
            if (this.CourseName == CourseName)
            {
                found = i;
            }
            return found;
        }
    }
}

