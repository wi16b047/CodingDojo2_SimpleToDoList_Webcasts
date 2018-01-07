using SimpleToDoList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.ViewModels
{
    public class ToDoVM
    {
        private ToDo toDo; //hidden

        public string Description //passing the value from that property to the toDo.Description property: the idea behind is that
        {
            get { return toDo.Description; } //toDo.Description hidden from the view as the view only knows public string Description
            set { toDo.Description = value; }
        }

        public bool Done
        {
            get { return toDo.Done; } 
            set { toDo.Done = value; }
        }

        public ToDoVM(string description, bool done)
        {
            toDo = new ToDo(description, done);         
        }

    }
}
