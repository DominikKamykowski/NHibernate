using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using kolokwium_.Mapping;

namespace kolokwium_.dtos
{
    public class PostDto
    {
        public TypePost Type { get; set; }
        public  string Topic { get; set; }
        public  string Description { get; set; }

        public  bool isPremium { get; set; }
    }
}