using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Servicio.Entidades
{
    public class Connection
    {
        private static string Sqlcom;
        public static string ConnectionString {

            get { return Connection.Sqlcom;}
            set { Connection.Sqlcom = value; }


        }

        

    }
}
