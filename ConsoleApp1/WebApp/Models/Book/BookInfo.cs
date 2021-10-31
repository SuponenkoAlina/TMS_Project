using Microsoft.AspNetCore.Mvc.Rendering;
using ProjectDb.Model;
using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public class BookInfo
    {
        public int BookId { get; set; }
               
        public string Title { get; set; }
                
        public int Year { get; set; }
        
        public Genre Genre { get; set; }
                
        public string Country { get; set; }
        public bool IsDeleted { get; set; }
        public SelectList SelectList { get; set; }
        public DateTime DateOfAdd { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
        public virtual ICollection<AudioBook> AudioBooks { get; set; }
        public virtual ICollection<Writer> Writers { get; set; }

       
    }
}
