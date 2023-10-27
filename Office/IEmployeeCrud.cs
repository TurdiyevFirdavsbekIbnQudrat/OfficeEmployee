using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office
{
    public interface IEmployeeCrud
    {
        void Created(EmployeeBase employee);
        void Update(EmployeeBase employee);
        void Delete(EmployeeDeleteCase employee);
        void DeepDelete();
        void GetAll();
        void GetByName(Employee employee ,string Name);
    }
}
