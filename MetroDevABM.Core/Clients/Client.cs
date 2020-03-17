using Abp.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using MetroDevABM.Genders;
using MetroDevABM.ClientTypes;

namespace MetroDevABM.Clients
{
    [Table("Clients")]
    public class Client : Entity
    {
        public const int MaxStringLenght = 50;
        public virtual string Name { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Address { get; set; }
        public virtual int ClientTypeId { get; set; }
        public virtual int GenderId { get; set; }
        [ForeignKey("ClientTypeId")]
        public virtual ClientType ClientType { get; set; }
        [ForeignKey("GenderId")]
        public virtual Gender Gender { get; set; }
        public Client()
        {
        }
    }
}
