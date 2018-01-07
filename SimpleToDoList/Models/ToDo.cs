using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.Models
{
    public class ToDo //the ToDo class is set to public
    {

        public String Description { get; set; }
        public Boolean Done { get; set; }
        public ToDo(string description, bool done)
        {
            Description = description;
            Done = done;
        }
    }
}
