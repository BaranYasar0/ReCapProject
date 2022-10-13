using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.FileUploadMethods
{
    public class GuidAdder
    {
        public static string AddGuid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
