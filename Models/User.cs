using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace RAMPControl.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public ICollection<Reports> Reports {get; set;}

        public User()
        {
            Reports = new Collection<Reports>();
        }
    }
}