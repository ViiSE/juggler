using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juggler
{
    public class JavaPropertiesDTO
    {
        public List<JdkPropertiesDTO> JdkPropertiesDTOs { get; set; }
        public List<string> JdkPathPatterns { get; set; }
    }
}
