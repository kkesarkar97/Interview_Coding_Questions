using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewCoding
{
    public class Test
    {
        public static int TestValue;
        static Test()
        {
            
            TestValue = 10;
        }

        public Test()
        {
            TestValue = 11;
        }

        public void TestVal()
        {
            TestValue = 12;
        }

        public void Display()
        {
            Console.WriteLine(TestValue);
        }
    }
}
