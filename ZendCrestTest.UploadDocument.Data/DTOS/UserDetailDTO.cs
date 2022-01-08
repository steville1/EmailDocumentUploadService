using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZendCrestTest.UploadDocument.Data.DTOS.Common;

namespace ZendCrestTest.UploadDocument.Data.DTOS
{
    public class UserDetailDTO : BaseDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Age { get; set; }
        public ICollection<FileDetailDTO> fileDetailDTO { get; set; }
    }
}
