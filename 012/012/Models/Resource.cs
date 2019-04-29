using System;
using System.Collections.Generic;

namespace _012.Models
{
    public partial class Resource
    {
        public System.Guid Id { get; set; }
        public System.Guid ClassId { get; set; }
        public string Title { get; set; }
        public string URL { get; set; }
        public Class Class { get; set; }
    }
}
