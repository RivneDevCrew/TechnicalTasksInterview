using System;
using System.Collections.Generic;
using System.IO;

namespace BinarySerializer
{
    [Serializable]
    public class Folder
    {
        private List<string> _directories;
        private List<string> _files;

        public Folder()
        {
            _directories = new List<string>();
            _files = new List<string>();
        }
         
        public Folder(string[] dirs, string[] files)
        {
            _directories = new List<string>();
            _files = new List<string>();

            foreach(string dir in dirs)
            {
                _directories.Add(dir);
            }

            foreach(string file in files)
            {
                _files.Add(file);
            }
        }

        public void Unpack(string dirPath)
        {
            string rootFolderPath = Path.GetDirectoryName(_directories[0]);
            foreach(var dir in _directories)
            {
                string newPath = dir.Replace(rootFolderPath, dirPath);
                Directory.CreateDirectory(newPath);
            }

            foreach(var file in _files)
            {
                string newPath = file.Replace(rootFolderPath, dirPath);
                File.Create(newPath);
            }
        }

        public override string ToString()
        {
            return "Folders: " + _directories.Count + " | Files: " + _files.Count;
        }
    }
}
