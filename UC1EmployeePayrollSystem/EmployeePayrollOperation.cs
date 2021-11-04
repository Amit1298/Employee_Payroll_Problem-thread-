using System;
using System.Collections.Generic;
using System.Text;

namespace UC1EmployeePayrollSystem
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeDetails> employeePayrollList = new List<EmployeeDetails>();
        public void addEmployeeToPayroll(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine(" Employee being added: " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine(" Employee added: " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.employeePayrollList.ToString());
        }
        public  void addEmployeePayroll(EmployeeDetails emp)
        {
            employeePayrollList.Add(emp);
        }
    }
}
