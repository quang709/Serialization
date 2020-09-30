using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;


namespace Serialization
{
    [Serializable()]
   public class Student : ISerializable
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public double Weight { get; set; }



        public Student(string name, int age, int id, double weight)
        {
            Name = name;
            Age = age;
            Id = id;
            Weight = weight;
        }
     public Student() { }


        public override string ToString()
        {
            return string.Format($"sinh vien {Name} co id {Id} nam nay {Age}");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Id", Id);
            info.AddValue("Name", Name);
            info.AddValue("Age", Age);
            info.AddValue("Weight", Weight);

        }
    }

}
