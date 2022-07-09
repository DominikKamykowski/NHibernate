using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kolokwium_.Mapping
{
    public class Post
    {
        public virtual int Id { get; set; }
        public virtual TypePost Type { get; set; }
        public virtual DateTime Date { get; set; }
        public virtual string Topic { get; set; }
        public virtual string Description { get; set; }

        public virtual bool isPremium { get; set; }
    }
}