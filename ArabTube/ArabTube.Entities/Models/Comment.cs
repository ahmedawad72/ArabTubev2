﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabTube.Entities.Models
{
    public class Comment
    {
        public Comment()
        {
            AppUser = new AppUser();    
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedOn { get; set; } = DateTime.Now;

        public bool IsUpdated { get; set; }

        public string UserId { get; set; }

        public AppUser AppUser { get; set; }

    }
}
