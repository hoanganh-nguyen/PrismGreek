using PrismGeek.Infra;
using PrismGeek.MasterTabControl.Models;
using PrismGeek.MasterTabControl.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismGeek.MasterTabControl.ViewModels
{
    public class StudentViewModel:ViewModelBase
    {
        IStudentRepository _studentRepository;
        private ObservableCollection<Student> _studentList;
        public ObservableCollection<Student> StudentList
        {
            get { return _studentList; }
            set { SetProperty(ref _studentList, value); }
        }

        public StudentViewModel(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
            Initilize();
        }

        private void Initilize()
        {
            var tmp = _studentRepository.LoadAll();
            StudentList = new ObservableCollection<Student>(tmp);
        }
    }
}
