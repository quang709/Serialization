using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>

            {
              new Student ("quang", 19, 1, 60.4),
              new Student ("quangg", 20, 2, 66.66),
                new Student ("quanggg", 20, 3, 66.66),
                  new Student ("quanggg", 20, 4444, 66.66),
            };
            string student_file = @"C:\Users\admin\source\repos\Serialization\Serialization\pxu.xml";
            using (Stream fs = new FileStream(student_file,FileMode.Create,FileAccess.Write,FileShare.None))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                xmlSerializer.Serialize(fs, students);
            }




            List<Student> students1 = null;
            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(List<Student>));

            using (FileStream fs1 =File.OpenRead(student_file))
            {
                students1 = (List<Student>)xmlSerializer1.Deserialize(fs1);
            }
            foreach (var item in students1)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }
}

