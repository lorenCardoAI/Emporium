using Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Entities
{
    public class ApplicationStatus : EntityBase
    {
        public int ReferenceId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Application> Applications { get; set; }

    }
}
