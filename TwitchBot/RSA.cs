using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace TwitchBot
{
    class Encryptor
    {
        private static byte[] Key;
        private static byte[] IV;

        static Encryptor()
        {
            string motherboardId = GetMotherboardId();
            string processorId = GetProcessorId();

            Key = CreateKeyOrIv(motherboardId, 32);
            IV = CreateKeyOrIv(processorId, 16);
        }

        private static string GetMotherboardId()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectCollection items = searcher.Get();

            foreach (ManagementObject item in items)
            {
                return item["SerialNumber"].ToString();
            }

            return String.Empty;
        }

        private static string GetProcessorId()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection items = searcher.Get();

            foreach (ManagementObject item in items)
            {
                return item["ProcessorId"].ToString();
            }

            return String.Empty;
        }

        private static byte[] CreateKeyOrIv(string id, int length)
        {
            while (id.Length < length)
            {
                id += id;
            }

            if (id.Length > length)
            {
                id = id.Substring(0, length);
            }

            return Encoding.UTF8.GetBytes(id);
        }

        public string Encrypt(string decrypted)
        {
            using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
            {
                ICryptoTransform icrypt = endec.CreateEncryptor(Key, IV);
                byte[] textbytes = Encoding.UTF8.GetBytes(decrypted);
                byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                return Convert.ToBase64String(enc);
            }
        }

        public string Decrypt(string encrypted)
        {
            try
            {
                using (AesCryptoServiceProvider endec = new AesCryptoServiceProvider())
                {
                    ICryptoTransform icrypt = endec.CreateDecryptor(Key, IV);
                    byte[] textbytes = Convert.FromBase64String(encrypted);
                    byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                    return Encoding.UTF8.GetString(enc);
                }
            }
            catch (FormatException)
            {
                throw new ArgumentException("Входная строка не является действительной Base64-строкой.");
            }
        }
    }
}