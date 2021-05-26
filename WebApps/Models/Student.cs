using System;
using System.ComponentModel.DataAnnotations;
/// <author>
/// Jamie Chopra
/// @version 0.1
/// </author>
namespace WebApps.Models
{
    public class Student
    {
        //Stores studentid as an int
        public int StudentId { get; set; }
        //Stores name in string
        [StringLength(20), Required]
        public string Name { get; set; }
        //Stores mark 0-100 only
        [Range(0, 100)]
        public int Mark { get; set; }

    }
}
