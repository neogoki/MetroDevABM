using Abp.Domain.Entities;
using System.Collections.Generic;
using MetroDevABM.Clients;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MetroDevABM.Genders
{
    [Table("Genders")]
    public class Gender: Entity
    {
        public const int MaxTitleLength = 256;
        
        [Required]
        [MaxLength(MaxTitleLength)]
        public virtual string Title { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
        public Gender()
        {
            
        }
    }
}
