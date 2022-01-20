using System.Collections.Generic;

namespace Juggler
{
    public class CheckerJdkPropertiesUnique : IChecker<JdkPropertiesDTO>
    {
        private readonly List<JdkPropertiesDTO> jdkPropertiesDTOs;

        public CheckerJdkPropertiesUnique(List<JdkPropertiesDTO> jdkPropertiesDTOs)
        {
            this.jdkPropertiesDTOs = jdkPropertiesDTOs;
        }

        public bool Check(JdkPropertiesDTO jdkPropertiesDTO)
        {
            foreach (var _jdkPropertiesDTO in jdkPropertiesDTOs)
            {
                if (jdkPropertiesDTO.Alias.Equals(_jdkPropertiesDTO.Alias))
                {
                    return false;
                }

                if (jdkPropertiesDTO.Path.Equals(_jdkPropertiesDTO.Path))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
