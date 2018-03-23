using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagement.Models
{
    public class Patient
    {
        [HiddenInput(DisplayValue = false), Display(Name = "ID")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string RightEyeParam_1 { get; set; }
        public string RightEyeParam_2 { get; set; }
        public string RightEyeParam_3 { get; set; }
        public string LeftEyeParam_1 { get; set; }
        public string LeftEyeParam_2 { get; set; }
        public string LeftEyeParam_3 { get; set; }

        [Column("DesesaseId"), Required(ErrorMessage = "প্রোডাক্ট-এর কেটাগরী সিলেক্ট করতে হবে"), Display(Name = "Desesase Name", Prompt = "প্রোডাক্ট এর কেটাগরী সিলেক্ট করুন")]
        public int DesesaseId { get; set; }
        [ForeignKey("DesesaseId"), Display(Name = "প্রোডাক্ট কেটাগরী", Prompt = "প্রোডাক্ট এর কেটাগরী সিলেক্ট করুন")]
        public virtual Desesase DesesaseName { get; set; }
    }
}
