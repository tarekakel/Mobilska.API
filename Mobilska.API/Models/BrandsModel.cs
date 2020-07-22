using System;
using System.Collections.Generic;

namespace Mobilska.API.Models
{
    public class BrandsModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Priority { get; set; }
        public string IconName { get; set; }
        public string MainImageUrl { get; set; }


    }
}
