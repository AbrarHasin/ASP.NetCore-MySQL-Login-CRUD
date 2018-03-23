using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.Models
{
    public class Desesase
    {
        [HiddenInput(DisplayValue = false), Display(Name = "ID")]
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage ="Too Short"), MaxLength(10, ErrorMessage = "Too Long")]
        public string Name { get; set; }
    }
}
