using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCompresor.Model
{
    public class mdlCompressionType
    {
        public enum CompressionType
        {
            ZIP,
            RAR,
            TAR,
            GZIP,
            BZIP2
        }
    }
}
