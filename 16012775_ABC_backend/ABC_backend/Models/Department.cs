﻿//Department model to show characteristics of department
//Triggered by CreateDepartment to add department record to department table and adds blob to table. 

using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ABCTask2
{
    public class Department : TableEntity
    {
        public Department(String rk)
        {
            this.PartitionKey = "ABC - Departments";
            this.RowKey = rk;
        }

        public Department()
        {

        }

        [Required]
        [MaxLength(63)]
        [MinLength(3)]
        [RegularExpression("^[a-z-]+$", ErrorMessage = "Directory Name must contain between 3 - 63 lowercase characters. Only hyphens are accepted as seperating characters!")]
        public String DepartmentName { get; set; }

        public String Description { get; set; }

        public int NumberOfItems { get; set; }
    }
}