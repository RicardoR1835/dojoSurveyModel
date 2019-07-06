using System;
using System.ComponentModel.DataAnnotations;

namespace dojosurv.Models
{
    public class MyModel
    {
        [Required]
        [MinLength(2)]
        public string Name {get;set;}

        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        public string Location {get;set;}

        [Required]
        public string Language {get;set;}

        [MinLength(20)]
        public string Comment {get;set;}
    }
}