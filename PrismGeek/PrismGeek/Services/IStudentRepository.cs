using PrismGeek.MasterTabControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismGeek.MasterTabControl.Services
{
    public interface IStudentRepository
    {
        IEnumerable<Student> LoadAll();
    }
}
