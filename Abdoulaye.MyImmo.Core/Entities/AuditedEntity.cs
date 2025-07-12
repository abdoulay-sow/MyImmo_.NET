using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Core.Entities
{
    public class AuditedEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? UpdatedBy { get; set; }
        protected AuditedEntity()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
