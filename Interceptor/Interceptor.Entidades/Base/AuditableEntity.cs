using System;
using System.Collections.Generic;
using System.Text;

namespace Interceptor.Base
{
    public class AuditableEntity
    {
        public virtual DateTime? OrderDate { get; set; }
    }
}
