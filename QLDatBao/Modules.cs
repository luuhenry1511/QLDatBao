﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLDatBao
{
    class Modules
    {
        public static string cnnStr = "Data Source=DESKTOP-8D1I3SF\\SQLEXPRESS;Initial Catalog=QLDATBAO;Integrated Security=True";
        public static SqlConnection cnn = new SqlConnection(cnnStr);



    }
}
