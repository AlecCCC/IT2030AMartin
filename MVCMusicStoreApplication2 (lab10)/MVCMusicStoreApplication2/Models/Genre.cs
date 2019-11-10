using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCMusicStoreApplication2.Models;
namespace MVCMusicStoreApplication2.Models
{
    public class Genre
    {
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }        
    }
}