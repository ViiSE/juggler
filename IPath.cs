using System.Collections.Generic;

namespace Juggler
{
    public interface IPath
    {
        void Change(string newPath, List<string> pathPatterns);
    }
}
