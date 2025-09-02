using System;
using System.ComponentModel.DataAnnotations;

namespace razordb.Models
{
    public class FutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime = (DateTime)value;
            return dateTime >= DateTime.Now;
        }
    }
}