using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieAPI.Models
{
    public class MovieItem
    {
        public long Id { get; set; }

        
        public string Name { get; set; }

        [DefaultValue(false)] 
        public bool IsComplete { get; set; }
    }
}
