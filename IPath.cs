using System.Collections.Generic;

namespace Juggler
{
    public interface IPath
    {
        string Change(string newPath, List<string> pathPatterns);
    }
}
