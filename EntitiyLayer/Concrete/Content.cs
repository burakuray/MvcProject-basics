﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concrete
{
    public class Content
    {

        [Key]
        public int ContentID { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        //Heading ile ilişkilendirme
        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        //Writer ile ilişkilendirme
        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
