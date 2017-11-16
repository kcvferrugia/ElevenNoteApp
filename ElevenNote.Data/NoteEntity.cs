using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    [Table("Note")] //METADATA: 'attribute' giving control over how the db handles the data
    public class NoteEntity
    {
        [Key] //'attribute' CHANGES the way data is stored in the system; reinforces relationships
        public int NoteId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }
        
        [Required]
        public string Title { get; set; }

        [MaxLength(500)] //CAPS storage space designated in db
        public string Content { get; set; }

        [DefaultValue(false)]
        public bool IsStarred { get; set; }

        [Required]
        public DateTime CreatedUtc { get; set; } //ALWAYS add 'Utc' to accomodate for time zones & daylight savings

        public DateTime? ModifiedUtc { get; set; } //? ALLOWS nulls in db (makes it not optional)
       
    }
}

