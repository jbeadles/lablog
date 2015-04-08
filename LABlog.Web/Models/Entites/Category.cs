using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace LABlog.Web.Models.Entities
{
    [TableName("Categories")]
    [PrimaryKey("Id")]
    public class Category :IEntity
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
