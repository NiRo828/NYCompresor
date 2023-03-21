using NYCompresor.Model;
using System.Collections.Generic;
using System.IO;

namespace NYCompresor.DAL
{
    public class FolderAccess
    {
        public FolderAccess GetFolder(string path)
        {
            if (Directory.Exists(path))
            {
                var folder = new mdlFolder
                {
                    Path = path,
                    SubFolders = GetAllSubFolders(path),
                    Files = GetFilesInFolder(path)
                };
                return folder;
            }
            return null;
            /* if (Directory.Exists(path))
             {
                 var folder = new Folder
                 {
                     Path = path,
                     SubFolders = GetAllSubFolders(path),
                     Files = GetFilesInFolder(path)
                 };
             }*/
        }

        public List<File> GetFilesInFolder(string path)
        {
            var fileList = new List<File>();
            var filePaths = Directory.GetFiles(path);

            foreach (var filePath in filePaths)
            {
                var file = new File
                {
                    Path = filePath,
                    Name = System.IO.Path.GetFileName(filePath)
                };
                fileList.Add(file);
            }

            return fileList;
        }

        public List<mdlFolder> GetAllSubFolders(string path)
        {
            var subFolderList = new List<mdlFolder>();
            var subDirectories = Directory.GetDirectories(path);

            foreach (var subDirectory in subDirectories)
            {
                var subFolder = GetFolder(subDirectory);
                subFolderList.Add(subFolder);
            }

            return subFolderList;
        }

    }
}
