using System.Collections.Generic;

namespace Juggler
{
    public class JavaPropertiesDTO
    {
        public List<JdkPropertiesDTO> JdkPropertiesDTOs { get; set; }
        public List<string> JdkPathPatterns { get; set; }
        public bool ChangeJdkBasedOnDefaultJdk { get; set; } = false;
        public bool AutomaticallySavePathAndJavaHome { get; set; } = false;
    }
}
