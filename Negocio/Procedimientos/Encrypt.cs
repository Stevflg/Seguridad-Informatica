using Datos.Proc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.Procedimientos
{
    public static class Encrypt
    {
        public static byte[] EncryptPass(string pass)
        {
            return DEncrypt.EncryptPass(pass);
        }
        public static string EncryptUser(string pass)
        {
           return DEncrypt.EncryptUser(pass);
        }
    }
}
