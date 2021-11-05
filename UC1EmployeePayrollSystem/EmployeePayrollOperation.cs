using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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
        public void addEmployeePayrollWithThread(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine(" Employee being add : " + employeeData.EmployeeName);
                    this.addEmployeePayroll(employeeData);
                    Console.WriteLine(" Employee added: " + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.employeePayrollList.Count);
        }
        public  void addEmployeePayroll(EmployeeDetails emp)
        {
            employeePayrollList.Add(emp);
        }
    }
}
