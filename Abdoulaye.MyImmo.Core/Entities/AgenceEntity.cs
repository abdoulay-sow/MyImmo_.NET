using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Core.Entities
{
    [Table("myimmo_t_agences")]
    public class AgenceEntity: AuditedEntity<Guid>
    {
        public Guid SocieteId { get; set; }
        public string Nom { get; set; } = default!;
        public string? Adresse { get; set; }

        // Navigation
        public SocieteEntity Societe { get; set; } = default!;
        public List<AgentEntity> Agents { get; set; } = new();
    }
}
