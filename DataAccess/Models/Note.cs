using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeanstalkNet.DataAccess.Models
{
    public class Note
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string Content { get; set; }
    }
}