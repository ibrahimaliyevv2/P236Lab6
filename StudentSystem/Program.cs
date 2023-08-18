using System;
using System.Collections.Generic;

namespace StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int studentNumberCounter = 1;
            bool continueCheck = true;

            while (continueCheck)
            {
                Console.WriteLine("Menyu:");
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Telebeye imtahan elave et");
                Console.WriteLine("3. Telebenin bir imtahan balina bax");
                Console.WriteLine("4. Telebenin butun imtahanlarini goster");
                Console.WriteLine("5. Telebenin imtahan ortalamasini goster");
                Console.WriteLine("6. Telebeden imtahan sil");
                Console.WriteLine("7. Proqrami bitir");

                int choice = Convert.ToInt32(Console.ReadLine());
                int studentNumber = 0;
                Student selectedStudent = null;

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Telebenin adini ve soyadini daxil edin:");
                        string fullName = Console.ReadLine();
                        students.Add(new Student { StudentNumber = studentNumberCounter, FullName = fullName });
                        studentNumberCounter++;
                        Console.WriteLine("Telebe elave edildi.");
                        break;
                    case 2:
                        Console.WriteLine("Telebe nomresini daxil edin:");
                        studentNumber = Convert.ToInt32(Console.ReadLine());

                        selectedStudent = students.Find(student => student.StudentNumber == studentNumber);

                        if (selectedStudent != null)
                        {
                            Console.WriteLine("Imtahan adi daxil edin:");
                            string examName = Console.ReadLine();
                            Console.WriteLine("Imtahan qiymetini daxil edin:");
                            int point = Convert.ToInt32(Console.ReadLine());

                            selectedStudent.AddExam(examName, point);
                            Console.WriteLine("Imtahan elave edildi.");
                        }
                        else
                        {
                            Console.WriteLine("Bu nomreye uygun telebe tapilmadi.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Telebenin nomresini daxil edin:");
                        studentNumber = Convert.ToInt32(Console.ReadLine());

                        selectedStudent = students.Find(student => student.StudentNumber == studentNumber);

                        if (selectedStudent != null)
                        {
                            Console.WriteLine("Imtahan adini daxil edin:");

                            string examName = Console.ReadLine();

                            int result = selectedStudent.GetExamResult(examName);
                            if (result != -1)
                            {
                                Console.WriteLine($"{selectedStudent.FullName} {examName} imtahan neticesi: {result}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Bu nomreye uygun telebe tapilmadi.");
                        }

                            break;
                    case 4:
                        Console.WriteLine("Telebenin nomresini daxil edin:");
                        studentNumber = Convert.ToInt32(Console.ReadLine());

                        selectedStudent = students.Find(student => student.StudentNumber == studentNumber);

                        if (selectedStudent != null)
                        {
                            Console.WriteLine("Telebenin imtahanlari ve neticeleri:");
                            Console.WriteLine($"Telebe: {selectedStudent.FullName}");
                            selectedStudent.GetAllExams();
                        }
                        else
                        {
                            Console.WriteLine("Bu nomreye uygun telebe tapilmadi.");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Telebenin nomresini daxil edin:");
                        studentNumber = Convert.ToInt32(Console.ReadLine());

                        selectedStudent = students.Find(student => student.StudentNumber == studentNumber);

                        if(selectedStudent != null)
                        {
                            double average = selectedStudent.GetExamAvg();
                            Console.WriteLine($"{selectedStudent.FullName} imtahan ortalamasi: {average}");
                        }
                        else
                        {
                            Console.WriteLine("Bu nomreye uygun telebe tapilmadi.");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Telebenin nomresini daxil edin:");
                        studentNumber = Convert.ToInt32(Console.ReadLine());

                        selectedStudent = students.Find(student => student.StudentNumber == studentNumber);

                        if(selectedStudent != null)
                        {
                            Console.WriteLine("Imtahan adini daxil edin:");
                            string examName = Console.ReadLine();

                            selectedStudent.RemoveExam(examName);
                            Console.WriteLine("Emeliyyat yerine yetirildi");
                        }
                        else
                        {
                            Console.WriteLine("Bu nomreye uygun telebe tapilmadi.");
                        }
                        break;
                    case 7:
                        continueCheck = false;
                        break;
                    default:
                        Console.WriteLine("Menyuda ele reqem yoxdur!!!");
                        break;
                }
            }
        }
    }
}
