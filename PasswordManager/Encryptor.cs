using System.Security.Cryptography;

namespace PasswordManager
{
    public class Encryptor
    {
        // Типа генерируем ключ
        // TODO: действительно генерировать ключ
        private readonly byte[] _key =
        {
            0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
            0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
        };

        // Шифрование
        public void Encrypt(string fileName, string message)
        {
            using (FileStream fileStream = new(fileName, FileMode.OpenOrCreate))
            {
                using (Aes aes = Aes.Create())
                {
                    // Устанавливаем ключ шифрования
                    aes.Key = _key;

                    // Получаем вектор инициализации
                    byte[] iv = aes.IV;
                    fileStream.Write(iv, 0, iv.Length);

                    using (CryptoStream cryptoStream = new(
                        fileStream,
                        aes.CreateEncryptor(),
                        CryptoStreamMode.Write))
                    {
                        using (StreamWriter encryptWriter = new(cryptoStream))
                        {
                            encryptWriter.Write(message);
                        }
                    }
                }
            }
        }

        // Дешифрование
        public string Decrypt(string fileName)
        {
            using (FileStream fileStream = new(fileName, FileMode.Open))
            {
                using (Aes aes = Aes.Create())
                {
                    // Читаем вектор инициализации
                    byte[] iv = new byte[aes.IV.Length];
                    int numBytesToRead = aes.IV.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                        if (n == 0) break;

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    using (CryptoStream cryptoStream = new(
                       fileStream,
                       aes.CreateDecryptor(_key, iv),   // Устанавливаем ключ шифрования и вектор инициализации
                       CryptoStreamMode.Read))
                    {
                        using (StreamReader decryptReader = new(cryptoStream))
                        {
                            string decryptedMessage = decryptReader.ReadToEnd();

                            return decryptedMessage;
                        }
                    }
                }
            }
        }
    }
}
