using System;
using System.Collections.Generic;
using System.Text;

namespace Projekat_Dom_Zdravlja
{
    class DBConnection
    {
        public string MyConection()
        {
            string con = @"Data Source=DESKTOP-MDQ23VJ; Initial Catalog=Dom_Zdravlja_v2; Integrated Security=True";
            return con;
        }
    }
}
