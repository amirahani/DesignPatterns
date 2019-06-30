using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Iterator_MP3Library
{
    public class M4aLocator : IEnumerable<FileInfo>
    {
        private string _startingPath;

        public M4aLocator(string startingPath)
        {
            _startingPath = startingPath;
        }

        public IEnumerator<FileInfo> GetEnumerator()
        {
            //return new MP3Enumerator(_startingPath);
            var files = Directory.EnumerateFiles(_startingPath,
                "*.m4a", SearchOption.AllDirectories);
            foreach (var file in files)
                yield return new FileInfo(file);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
