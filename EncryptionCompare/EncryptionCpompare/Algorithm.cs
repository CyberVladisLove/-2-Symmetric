using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCompare
{
    class Algorithm
    {
        protected SymmetricAlgorithm sa;
        
        public string Name { get; private set; }

        protected byte[] Cipherbytes { get; set; }

        public static int cypherModeCount = 5;
        public Algorithm(SymmetricAlgorithm sa, string name)
        {
            this.sa = sa;
            this.Name = name;
            InitSA();  
        }

        private void InitSA()
        {
            sa.GenerateKey();
            sa.GenerateIV();
            sa.Padding = PaddingMode.PKCS7;  
        }

        public void SetCipherMode(CipherMode cm)
        {
            sa.Mode = cm;
        }

        public string Encryption(string content)
        {              
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, sa.CreateEncryptor(), CryptoStreamMode.Write);

            byte[] plainbytes = Encoding.UTF8.GetBytes(content);

            cs.Write(plainbytes, 0, plainbytes.Length);
            cs.Close();

            Cipherbytes = ms.ToArray();
            ms.Close();

            return Encoding.UTF8.GetString(Cipherbytes);
        }
        public string Decryption()
        {    
            MemoryStream ms = new MemoryStream(Cipherbytes);
            CryptoStream cs = new CryptoStream(ms, sa.CreateDecryptor(), CryptoStreamMode.Read);

            byte[] plainbytes = new byte[Cipherbytes.Length];

            cs.Read(plainbytes, 0, Cipherbytes.Length);
            cs.Close();

            cs.Close();
            ms.Close();
            
            return Encoding.UTF8.GetString(plainbytes);
        }
        public static CipherMode GetCipherMode(int val)
        {
            return val switch
            {
                0 => CipherMode.ECB,
                1 => CipherMode.CBC,
                2 => CipherMode.CFB,
                3 => CipherMode.OFB,
                _ => CipherMode.CTS,
            };
        }

        public void Encryption_Decryption(string content)
        {
            Encryption(content);
            Decryption();
        }
    }
}
