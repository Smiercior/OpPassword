using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace OpPassword
{
    public class EncyprtDecrypt
    {
        private readonly byte[] key;
        private readonly byte[] iv;

        // Create key and iv using password
        public EncyprtDecrypt(string password)
        {
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            key = SHA256.Create().ComputeHash(passwordBytes);
            iv = SHA256.Create().ComputeHash(key).Take<byte>(16).ToArray();
        }

        // Encrypt input using password
        public string Encrypt(string input)
        {
            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                var encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (var ms = new MemoryStream())
                {
                    using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(input);
                        }
                    }
                    var encrypted = ms.ToArray();
                    return Convert.ToBase64String(encrypted);
                }
            }
        }

        // Decrpyt input using password
        public string Decrypt(string input)
        {
            // If password is not correct, return encrypted input
            try
            {
                using (var aes = Aes.Create())
                {
                    aes.Key = key;
                    aes.IV = iv;

                    var decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                    using (var ms = new MemoryStream(Convert.FromBase64String(input)))
                    {
                        using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                        {
                            using (var sr = new StreamReader(cs))
                            {
                                return sr.ReadToEnd();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return input;
            }        
        }
    }
}
