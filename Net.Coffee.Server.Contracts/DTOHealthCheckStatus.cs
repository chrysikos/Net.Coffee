﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Coffee.Server.Contracts
{
    public class DTOHealthCheckStatus
    {
        public string Status { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
