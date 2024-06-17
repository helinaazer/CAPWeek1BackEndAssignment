using System.Security.Cryptography;

namespace Week1 {
    class Student {

        public int age;
        public string name;
        public int Age{
            get{
                return age;
            }
            set{
                age = value;
            }
        }

        public string Name{
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public Student (string name, int age) {
            this.age = age;
            this.name = name;
        }
    }
}