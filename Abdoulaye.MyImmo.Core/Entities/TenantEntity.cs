using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Core.Entities
{
    [Table("myimmo_t_tenants")]
    public class TenantEntity: AuditedEntity<Guid>
    {
        public string Name { get; set; } = default!;
        public string ConnectionString { get; set; } = default!;
    }
}
