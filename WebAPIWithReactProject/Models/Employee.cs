using System;
using System.Collections.Generic;

namespace WebAPIWithReactProject.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string Name { get; set; } = null!;

    public string City { get; set; } = null!;

    public string Department { get; set; } = null!;

    public string Gender { get; set; } = null!;
}
