using System;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class ErrMessage
    {
        public int ID { get; set; }
        public string Message { get; set; }

        public ErrMessage(int ID)
        {
            this.ID = ID;
        }
    }
}