using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeanstalkNet.Models
{
    public class NotesViewModel
    {
        public List<NoteViewModel> Notes { get; set; }
    }
    public class NoteViewModel
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Content { get; set; }
    }
}