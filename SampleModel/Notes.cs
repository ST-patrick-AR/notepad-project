using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleModel
{

    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public int CategoryId { get; set; }
        public Note()
        {
            DateCreated = DateTime.Now;
            DateModified = DateTime.Now;
        }
    }

}
