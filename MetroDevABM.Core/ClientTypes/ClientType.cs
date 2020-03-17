using Abp.Domain.Entities;
using System.Collections.Generic;
using MetroDevABM.Clients;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetroDevABM.ClientTypes
{
    [Table("ClientTypes")]
    public class ClientType: Entity
    {
        public const int MaxTitleLength = 50;
        public const int MaxDescriptionLength = 500;

        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

        public ClientType()
        {
            
        }
    }
}
