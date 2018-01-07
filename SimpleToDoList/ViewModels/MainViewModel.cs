using SimpleToDoList.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleToDoList.ViewModels
{
    class MainViewModel
    {
        private string newTaskDescription = "";

        private RelayCommand addBtnClickedCommand;

        public RelayCommand AddBtnClickedCommand
        {
            get { return addBtnClickedCommand; }
            set { addBtnClickedCommand = value; }
        }


        public string NewTaskDescription //upper camel case
        {
            get { return newTaskDescription; }
            set { newTaskDescription = value; }
        }

        //use ObservableCollections in ViewModels instead of lists... in order to store all values and create an instance before starting the application otherwise it would be empty
        private ObservableCollection<ToDoVM> toDoList = new ObservableCollection<ToDoVM>();

        public ObservableCollection<ToDoVM> ToDoList
        {
            get { return toDoList; }
            set { toDoList = value; }
        }

        public MainViewModel()
        {
            //create an instance of the AddBtnClickedCommand
            AddBtnClickedCommand = new RelayCommand(new Action(AddButtonClicked), new Func<bool>(CanExecute));
            LoadData();
        }

        private bool CanExecute()
        {
            //return true; -> so we can always click that button
            return NewTaskDescription.Length > 0;
        }

        private void AddButtonClicked()
        {
            //logic what should happen if the button is clicked
            ToDoList.Add(new ToDoVM(NewTaskDescription, false));
        }

        private void LoadData()
        {
            ToDoList.Add(new ToDoVM("Add something", false));
            ToDoList.Add(new ToDoVM("Add anything", true));
        }

    }
}
