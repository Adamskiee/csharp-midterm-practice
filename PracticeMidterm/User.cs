using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeMidterm
{
    // Note that this class violates naming convention. This makes deserialization 
    // short or easy to understand as the `users.json` also uses lowercase fields
    internal class User
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string website { get; set; }
    }
}
