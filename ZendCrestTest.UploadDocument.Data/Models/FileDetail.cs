using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZendCrestTest.UploadDocument.Data.Common;

namespace ZendCrestTest.UploadDocument.Data.Models
{
    public class FileDetail:BaseDomainEntity
    {
        public string UserId { get; set; }
        public string FileName { get; set; }
        public UserDetail userDetail { get; set; }
    }
}
