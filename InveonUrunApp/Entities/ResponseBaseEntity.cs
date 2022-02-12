using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InveonUrunApp.Entities
{
    public class ResponseBaseEntity
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}