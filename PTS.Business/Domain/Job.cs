﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public class Job : IDomainBase
    {
        public int Id { get; set; }

        public Guid UUID { get; set; }

        public string Image { get; set; }

        public bool IsActive { get; set; }
    }
}
