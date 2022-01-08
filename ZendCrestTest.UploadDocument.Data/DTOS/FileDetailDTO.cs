using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZendCrestTest.UploadDocument.Data.DTOS.Common;

namespace ZendCrestTest.UploadDocument.Data.DTOS
{
    public class FileDetailDTO : BaseDTO
    {
        public string UserId { get; set; }
        public string FileName { get; set; }
        public UserDetailDTO userDetailDTO { get; set; }
    }
}
