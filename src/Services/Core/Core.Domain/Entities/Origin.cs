using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Models
{
    public class Origin
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Text { get; set; }
        public bool Cestino { get; set; }
        public int Order { get; set; }

    }
}
