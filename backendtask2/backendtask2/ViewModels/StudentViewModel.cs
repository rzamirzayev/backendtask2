using backendtask2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backendtask2.ViewModels
{
    public class StudentViewModel 
    {
        public List<Group> Groups { get; set; }
        public List<Student> Students { get; set; }
    }
}
