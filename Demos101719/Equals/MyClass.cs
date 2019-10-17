using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equals
{
    class MyClass
    {
        private int someNumber;
        private string someString;

        public MyClass(int num, string str)
        {
            this.someNumber = num;
            this.someString = str;
        }

        public override bool Equals(object obj)
        {
            // default parent class is system objects - unknown result
            // return base.Equals(obj);
            // comparison
            // create a temp variable

            if(obj is MyClass && obj != null)
            {
                MyClass temp;
                temp = (MyClass)obj;

                // are the two numbers equal and are the two strings equal
                if ((temp.someNumber == this.someNumber) &&
                        temp.someString.Equals(this.someString)) return true;
                else return false;
            }
            return false;
        }
    }
}
