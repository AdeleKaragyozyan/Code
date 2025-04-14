using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class FileRequest
    {
        public string Name { get; set; }
        public FileRequest() {}
        public FileRequest(string name) {  this.Name = name; }
        public void MakeRequest()
        {
            Console.WriteLine($"Processing file: {Name}");
        }
    }
}
