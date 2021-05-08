using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        public string name(int i)
        {
            string k = "";
            switch (i)
            {
                case 1:
                    k = "Tom";
                    break;
                case 2:
                    k = "Dick";
                    break;
                case 3:
                    k = "Harry";
                    break;
                case 4:
                    k = "Bubba";
                    break;
            }
            return k;
            /*
            string nameString;
            int next;

            string[] title = new string[] { "Tom", "Dick", "Harry", "Bubba" };


            public  Person()
            {
                nameString = title[next++];
            }
            public string name()
            {
                return nameString;
            }*/
        }
    }
}