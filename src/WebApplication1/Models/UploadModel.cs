using System.Collections.Generic;
using System.Web;

namespace WebApplication1.Models
{
    public class UploadModel
    {
        public List<HttpPostedFileBase> Files { get; set; }

        public UploadModel()
        {
            Files = new List<HttpPostedFileBase>();
        }
    }
}