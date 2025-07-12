using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abdoulaye.MyImmo.Core.Entities
{
    [Table("myimmo_t_agents")]
    public class AgentEntity : AuditedEntity<Guid>
    {
        public Guid AgenceId { get; set; }
        public string Nom { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string? Telephone { get; set; }

        // Navigation
        public AgenceEntity Agence { get; set; } = default!;
    }
}
