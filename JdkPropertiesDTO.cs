using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juggler
{
    public class JdkPropertiesDTO
    {
        public string Alias { get; set; }
        public string Path { get; set; }
        public bool IsDefault { get; set; } = false;
    }
}
