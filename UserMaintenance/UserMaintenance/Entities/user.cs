using System;

namespace UserMaintenance.Entities
{
    public class user
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string full_name{ get; set; }
    }
}