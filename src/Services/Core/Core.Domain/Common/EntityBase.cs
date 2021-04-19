using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Common
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
    }
}
