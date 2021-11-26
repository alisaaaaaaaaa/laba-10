using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hw_10_
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            string path = $@"{Environment.CurrentDirectory}\студенты.csv";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line.Split(';').First());
                    student.GetName(line.Split(';').First());
                    if (line.Split(';').Length > 1)
                    {
                        line = line.Split(';').Last();
                        Console.WriteLine(line.Split(';').First());
                        student.GetGroupNumber(line.Split(';').First());
                    }

                    if (line.Split(';').Length > 1)
                    {
                        line = line.Split(';').Last();
                        Console.WriteLine(line.Split(';').First());
                    }

                }
            }
            student.Print();
        }
    }
}
