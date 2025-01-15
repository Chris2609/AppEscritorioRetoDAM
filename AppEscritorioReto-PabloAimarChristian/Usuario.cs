using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscritorioReto_PabloAimarChristian
{
    internal class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }

        public Usuario() { }

        public Usuario(int id, string name, string password, bool admin)
        {
            Id = id;
            Name = name;
            Password = password;
            Admin = admin;
        }
    }
}
