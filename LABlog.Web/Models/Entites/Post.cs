using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace LABlog.Web.Models.Entities
{
    [TableName("Posts")]
    [PrimaryKey("Id")]
    public class Post : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Abstract { get; set; }
        public string Slug { get; set; }
        public string PostedBy { get; set; }
        public DateTime Created { get; set; }
        public bool Published { get; set; }
        public int CategoryId { get; set; }
    }
}
