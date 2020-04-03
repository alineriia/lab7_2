using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* У текстовому файлі записана інформація про людей (прізвище, ім'я, по
батькові, вік, вага через пробіл). Вивести на екран інформацію про людей, відсортовану
за віком. (ArrayList перевантаження методу Compare).
*/
namespace lab7_2
{
    class Person
    {
        string surname;
        string name;
        string pb;
        int vik;
        float mass;
        public override string ToString()
        {
            string inf = string.Empty;
            inf += ("\n\nName: " + name);
            inf += ("\nSurname: " + surname);
            inf += ("\nAge: " + vik);
            return inf;
        }
        public Person()
        {

        }
        public Person(string s,string n,string p,int v,float m)
        {
            surname = s;
            name = n;
            pb = p;
            vik = v;
            mass = m;
        }
        public int Vik
        {
            get
            { 
                return vik;
            }
        }

    }
}
