using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
//BIT 285
//Assignment 2
//Joan Dawson
namespace Assignment2.ViewModels
{
    public class PGViewModel
    {

        public string PasswordChosen { get; set; } //what the user chose from the list
        public string LastName { get; set; }
        public string FavColor { get; set; }
        public string BirthYear { get; set; }

        public List<SelectListItem> Passwords { get; set; }


    }
}