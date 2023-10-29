using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateEmployee
{
   
    // PROPERTY METHOD EXAMPLE
    //without using getter,setter short cut we are defining getter and setter in old way
using System;
 
public class Employee

    {
        //private variables 
      
        private string empCode;   // private string epmCode { get;set }

        private string  empName;

        private double empSal;

        private char deptCode;

        private static int empCounter = 1000;


        // getter and setters for each variables  
        public string EMPCode           //method for getting and setting empcode  --this is a method that can access private variable and set the value when set by user  and return the value to one who called called get

        {

            get { return empCode; }

            set { empCode = value; }

        }

        public string EmpName

        {

            get { return empName; }

            set { empName = value; }

        }

        public double EmpSal

        {

            get { return empSal; }

            set { empSal = value; }

        }

        public char DeptCode

        {

            get { return deptCode; }

            set { deptCode = value; }

        }

        private string GenerateEmployeeCode()

        {

            empCounter++;

            return $"{deptCode}{empCounter}";

        }

        public Employee(string empName, double empSal, char deptCode)

        {

            this.EmpName = empName;       // setting emp code using getter and setter METHOD

            this.EmpSal = empSal;

            this.DeptCode = deptCode;

            this.EMPCode = GenerateEmployeeCode();

        }

        public Employee(string empName, double empSal)

        {

            this.EmpName = empName;

            this.EmpSal = empSal;

            this.DeptCode = 'A';

            this.EMPCode = GenerateEmployeeCode();    

        }

        public string GetEmployeeDetails()

        {

            return $"Code-{EMPCode},Name-{EmpName},Salary-{EmpSal:F2},Department-{DeptCode}";   //gertting the employeecode using EmpCode Method

        }

       

    }
}



/*
 public class Employee
{
 private string empCode;
 public string EMPCode           //method for getting and setting empcode  --this is a method that can access private variable and set the value when set by user  and return the value to one who called called get

        {

            get { return empCode; }

            set { empCode = value; }

        }
}

public Employee(string empcode)      // constructor of class with paramter
{
this.EMPCode = empcode             // EMPCode is a property method ...empcode is sett to EMPCode
}

//main

 Employee e = new Employee("A")   //instantiating the constructor with parameter

        //here the  the code'A' goes to contructor --> there it setts the value to EMPCode property_method --> from there it goes to property method defintion 



 */


// OR WE CAN SIMPLY DO

/*
public class Employee
{
 private string  Empcode{get; set;}   //property vaiable
public Employee(string code)
{
 this.Empcode =code;
}

}

//main
Employee e = new Employee("A");

 */








//calling getdeatails method and display method
//using default constructor that automatically setts a hardcoded value to a variable of class
// using parameterised constructor to set a dynamic value to a variale inside class
// using set method for setting a value to a variable when set method is called.using get method for getting the value which will be return after calling it to the user.calling display method to print the value of the variable.

//using property method  EMP_NAME{get{return emp_name;} set emp_name=value;}
                        //Constructor(string loal_param){this.EMP_NAME = local_param} which setts the value to emp_name by using property_method when a parameterised contructor is automaticalled when ...Class obj =new Class("indra") is used
                        //display the name using COnsole.WriteLine({EMP_NAME})   --this will call the funtion that calls get funtion of property

//autoimplementation property --private string name{get; set;}
                               // Class obj = new Class(){name="Indra"}  //this is shortcut for implementation of name using property