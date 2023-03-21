using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCompresor.Model
{
    public class Folder
    {
        public string Path { get; set; }
        public List<Folder> SubFolders { get; set; }
        public List<File> Files { get; set; }
    }

    //Todo: Create a enum list of compression types
    enum CompressionType
    {
        ZIP,
        RAR,
        TAR,
        GZIP,
        BZIP2
    }

    public class CompressedFile
    {
        public string Path { get; set; }
        public CompressionType CompressionType { get; set; }
    }
}
