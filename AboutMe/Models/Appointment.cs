﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AboutMe.Models
{
    public class Appointment
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int ObjectId { get; set; }

        public string ObjectType { get; set; }

        public string Type { get; set; }

        public DateTime fromDate { get; set; }

        public DateTime toDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public DateTime CreatedDate { get; set; }

    }
}
