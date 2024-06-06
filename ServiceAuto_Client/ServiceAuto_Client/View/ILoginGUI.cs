using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAuto_Client.View
{
    public interface ILoginGUI
    {
        string Username { get; set; }
        string Password { get; set; }
        //void Login();
    }
}
