using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Iterator_MP3Library
{
    internal class M4aEnumerator : IEnumerator<FileInfo>
    {
        private string _startingPath;
        private IEnumerator<string> _fileEnumerator;

        public M4aEnumerator(string startingPath)
        {
            _startingPath = startingPath;
            var file = Directory.EnumerateFiles(_startingPath,
                "*.m4a", SearchOption.AllDirectories);
            _fileEnumerator = file.GetEnumerator();
        }

        public FileInfo Current
        {
            get { return new FileInfo(_fileEnumerator.Current); }
        }

        object IEnumerator.Current
        {
            get { return this.Current; }
        }

        public bool MoveNext()
        {
            return _fileEnumerator.MoveNext();
        }

        public void Reset()
        {
            _fileEnumerator.Reset();
        }

        public void Dispose()
        {
            _fileEnumerator.Dispose();
        }

    }
}
