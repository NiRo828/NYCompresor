using NYCompresor.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;


namespace NYCompresor.Entities
{
    public class FolderCompressionService
    {
        private readonly FolderAccess _folderAccess;

        public FolderCompressionService()
        {
            _folderAccess = new FolderAccess();
        }

        public mdlCompressedFile CompressFolder(string folderPath, CompressionType compressionType)
        {
            Folder folder = _folderAccess.GetFolder(folderPath);

            if (folder == null)
            {
                throw new DirectoryNotFoundException("The specified folder does not exist.");
            }

            string compressedFilePath = $"{folder.Path}.{compressionType.ToString().ToLower()}";
            mdlCompressedFile compressedFile = new mdlCompressedFile { Path = compressedFilePath, CompressionType = compressionType };

            switch (compressionType)
            {
                case CompressionType.ZIP:
                    ZipFile.CreateFromDirectory(folder.Path, compressedFilePath);
                    break;
                case CompressionType.WINRAR:
                    // Implement the WinRAR compression logic.
                    break;
                case CompressionType.GUNZIP:
                    // Implement the GUNZIP compression logic.
                    break;
                default:
                    throw new NotSupportedException("The specified compression type is not supported.");
            }

            return compressedFile;
        }
    }
}
