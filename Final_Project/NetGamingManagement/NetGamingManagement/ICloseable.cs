using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetGamingManagement
{
    public interface ICloseable
    {
        event EventHandler CloseRequest;
    }
}
