using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mp3Player.Entities
{
    public class Song
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Song() { }

        public Song(string songPath)
        {
            this.Path = songPath;
            int index = this.Path.LastIndexOf('\\');
            this.Name = this.Path.Substring(index + 1);
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
