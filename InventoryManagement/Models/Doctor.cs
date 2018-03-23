using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.Models
{
    public class Doctor
    {
        [HiddenInput(DisplayValue = false), Display(Name = "ID")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Dec{ get; set; }
    }
}
