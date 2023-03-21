using NYCompresor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NYCompresor.DAL
{
    public class FolderAccess
    {
        public FolderAccess GetFolder(string path)
        {
            return new FolderAccess();
        }

        public List<Folder> GetAllSubFolders(Folder folder)
        {
            return new List<Folder>();
        }

    }
}
