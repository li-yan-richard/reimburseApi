using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class FileDetail
    {
        public string fileName { get; set; }
        public int fileSize { get; set; }
        public string fileType { get; set; }
        public int lastModifiedTime { get; set; }
        public DateTime lastModifiedDate { get; set; }
        public string fileAsBase64 { get; set; }
    }
}
