using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateXML(Example1(), "..\\..\\..\\data.xml");
        }
        static void CreateXML(Dep d, string Path = "data.xml")
        {
            XElement main = new XElement("Main");
            foreach (var person in d.Departaments)
            {
                XElement User = new XElement("User");
                XElement Fname = new XElement("Fname");
                Fname.Value = person.Fname;
                XElement Lname = new XElement("Lname");
                Lname.Value = person.Lname;
                XAttribute id = new XAttribute("id", person.id);
                User.Add(Fname, Lname, id);
                main.Add(User);
            }
            main.Save(Path);
        }
        static Dep Example1()
        {
             Dep d = new
                Dep(
                new User() { Fname = "Name 1", Lname = "SecondName1", id = 1 },
                new User() { Fname = "Name 2", Lname = "SecondName2", id = 2 },
                new User() { Fname = "Name 3", Lname = "SecondName3", id = 3 },
                new User() { Fname = "Name 4", Lname = "SecondName4", id = 4 },
                new User() { Fname = "Name 5", Lname = "SecondName5", id = 5 }
                );
            return d;
        }

    }
}
