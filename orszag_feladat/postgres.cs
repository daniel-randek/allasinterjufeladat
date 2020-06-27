using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MiNET;
using MiNET.UI;
using Npgsql;

namespace orszag_feladat
{
    public partial class PostGres : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        public PostGres()
        {
        }

        public override void FromJson(string json, Player player)
        {
            throw new NotImplementedException();
        }
    }
}
