using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class User
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int id { get; set; }
    }
    class Dep
    {
        private Dep()
        {

        }
        List<User> dep = new List<User>();
        public Dep(params User[] Args )
        {
            foreach(var e in Args) { dep.Add(e); }
        }
        public List<User> Departaments { get { return dep; } }
    }
}
