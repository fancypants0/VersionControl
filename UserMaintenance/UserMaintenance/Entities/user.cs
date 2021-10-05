using System;

namespace UserMaintenance.Entities
{
    public class user
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string full_name{get{ return string.Format(last_name + " " + first_name); }}
    }
}