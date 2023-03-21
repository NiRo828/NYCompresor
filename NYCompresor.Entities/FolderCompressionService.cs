using NYCompresor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCompresor.Entities
{
    public class FolderCompressionService
    {
        public CompressedFile CompressFolder(FolderCompressionService folder, CompressionType compressionType)
        {
            if (compressionType is null)
            {
                throw new ArgumentNullException(nameof(compressionType));
            }
            // Implement logic to compress folder and its subfolders based on the selected compression type


            // Return the compressed file
            return new CompressedFile();
            

        }

    }
}
