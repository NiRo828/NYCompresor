using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCompresor.Model
{
    public class mdlFolder
    {
        public string Path { get; set; }
        public List<mdlFolder> SubFolders { get; set; }
        public List<mdlFile> Files { get; set; }

        public mdlFolder()
        {
            SubFolders = new List<mdlFolder>();
            Files = new List<mdlFile>();
        }
    }
    public class mdlFolder
    {
        public string Path { get; set; }
        public List<mdlFolder> SubFolders { get; set; }
        public List<mdlFile> Files { get; set; }
    }

    //Todo: Create a enum list of compression types
    public enum CompressionType
    {
        ZIP,
        RAR,
        TAR,
        GZIP,
        BZIP2,
        WINRAR,
        GUNZIP
    }

    /*public class CompressedFile
    {
        public string Path { get; set; }
        public CompressionType CompressionType { get; set; }
    }*/
}
