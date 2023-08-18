using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem
{
    public class Student
    {
        public int StudentNumber { get; set; }
        public string FullName { get; set; }
        public Dictionary<string, int> Exams = new Dictionary<string, int>();

        public void AddExam(string examName, int point)
        {
            Exams[examName] = point;
        }

        public int GetExamResult(string examName)
        {
            if (Exams.ContainsKey(examName))
            {
                return Exams[examName];
            }
            else
            {
                Console.WriteLine("Bu imtahan tapilmadi.");
                return -1;
            }
        }

        public void GetAllExams()
        {
            foreach (var exam in Exams)
            {
                Console.WriteLine($"{exam.Key}: {exam.Value}");
            }
        }

        public double GetExamAvg()
        {
            if (Exams.Count == 0)
            {
                Console.WriteLine("Telebenin hec bir imtahani yoxdur.");
                return 0;
            }

            int totalPoints = 0;

            foreach (var point in Exams.Values)
            {
                totalPoints += point;
            }

            return (double)totalPoints / Exams.Count;
        }

        public void RemoveExam(string examName)
        {
            if (Exams.ContainsKey(examName))
            {
                Exams.Remove(examName);
                Console.WriteLine($"{examName} imtahani silindi.");
            }
            else
            {
                Console.WriteLine("Bele bir imtahan tapilmadi.");
            }
        }
    }
}