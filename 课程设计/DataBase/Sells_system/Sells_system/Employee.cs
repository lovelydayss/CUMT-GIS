using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sells_system
{
    public class Employee
    {
        private int employeeId;
        private string employeeName;
        private string employeePhone;
        private string employeeAdress;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeePhone { get => employeePhone; set => employeePhone = value; }
        public string EmployeeAdress { get => employeeAdress; set => employeeAdress = value; }
    }
}
