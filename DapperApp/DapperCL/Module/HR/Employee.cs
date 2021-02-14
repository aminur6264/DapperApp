﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DapperCL.Module.HR
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GenderId { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string EmployeeTypeId { get; set; }
        public int? DepartmentId { get; set; }
    }
}
