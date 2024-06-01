using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Server.Domain.Language
{
    public interface Observable
    {
        void Update(Subject obs);
    }
}
