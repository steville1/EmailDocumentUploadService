using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZendCrestTest.UploadDocument.Data.Common;

namespace ZendCrestTest.UploadDocument.Data.Models
{
    public class UserDetail:BaseDomainEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public ICollection<FileDetail> fileDetails { get; set; }
    }
}
