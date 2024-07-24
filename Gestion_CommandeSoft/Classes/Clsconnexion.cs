using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
namespace Gestion_CommandeSoft.Classes
{
  class Clsconnexion
    { 
        public string
  GetconnectionString()
        {
            string filePath = (@"C:\Chemin\Gestioncommande_soft.txt");
            string  connectionString = File.ReadAllText(filePath);
            return connectionString;
        }

       
    }

}
