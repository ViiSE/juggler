using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juggler
{
    public interface IProperties<T>
    {
        T Get();
        void Save();
    }
}
