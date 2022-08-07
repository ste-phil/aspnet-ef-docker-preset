using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HomeApp.Entities
{
    public class Bucket 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Name { get; set; }
        public ICollection<Entry> Entries { get; set; }

    }

    public class Entry 
    {
        public string Value { get; set; }
    }
}