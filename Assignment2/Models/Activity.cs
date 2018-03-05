using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
//BIT 285
//Assignment 2
//Joan Dawson
namespace Assignment2.Models
{
    public class Activity
    {
        //defines the entities needed for the Activity model
        public int ActivityID { get; set; }
        public string ActivityName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ActivityDate { get; set; }
        public string IpAddress { get; set; }
    }
}