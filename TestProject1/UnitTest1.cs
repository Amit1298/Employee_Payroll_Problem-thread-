using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UC1EmployeePayrollSystem;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Given10Employee_WhenAddedToList_ShouldMatchEmployeeEntries()
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay:210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            employeeDetails.Add(new EmployeeDetails(EmployeeID: 1, EmployeeName: "Amit", PhoneNumber: "989897989", Address: "Defence Colony Agra", Department: "Accounts", Gender: 'M', BasicPay: 123.3, Dection: 45, TaxablePay: 60.3, NetPay: 210, Tax: 29.1, City: "Agra", Country: "India"));
            EmployeePayrollOperation employeePayrollOperation = new EmployeePayrollOperation();
            DateTime startDateTime = DateTime.Now;
            employeePayrollOperation.addEmployeeToPayroll(employeeDetails);
            DateTime stopDateTime = DateTime.Now;
            Console.WriteLine("Duration without thread: "+ (stopDateTime-startDateTime));
        }
    }
}
