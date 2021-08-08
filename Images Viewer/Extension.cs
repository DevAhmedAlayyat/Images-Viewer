using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Images_Viewer
{
    public static class Extension
    {
        public static bool HasImageExtensions(this string fileName)
        {
            return fileName.ToLower().Contains("jpg") || fileName.ToLower().Contains("png") || fileName.ToLower().Contains("jpeg");
        }
    }
}
