using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Core.Entities
{
    [Table("myimmo_t_societes")]
    public class SocieteEntity: AuditedEntity<Guid>
    {
        public Guid TenantId { get; set; }
        public string Nom { get; set; } = default!;
        public string? Adresse { get; set; }

        // Navigation
        public List<AgenceEntity> Agences { get; set; } = new();
    }
}
