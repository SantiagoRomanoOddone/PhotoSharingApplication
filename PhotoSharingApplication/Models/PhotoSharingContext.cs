using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity; //a
namespace PhotoSharingApplication.Models
{
    //Argreg DbContext
    public class PhotoSharingContext : DbContext
    {
        //Lo agregue yo
        public PhotoSharingContext() : base("KeyDB") { }

        public DbSet<Photo> Photos { get; set; }
        public DbSet<Comment> Comments { get; set; }


    }
}