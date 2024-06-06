using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Client.Language
{
    public interface Observable
    {
        void Update(Subject obs);
    }
}
