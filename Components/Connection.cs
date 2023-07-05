using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAloverasPharmacyPOSSystem.Components
{
    class Connection
    {
        Components.Values val = new Components.Values();

        public string conString()
        {
            return String.Format("datasource = {0}; username = {1}; password = {2}; port = {3}; database = {4};",
                val.serverName, val.serverUser, val.serverPass, val.port, val.database);
        }
    }
}
