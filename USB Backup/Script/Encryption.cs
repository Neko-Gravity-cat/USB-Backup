using System;
using System.IO;
using System.Security.Cryptography;

namespace USB_Backup {
    public class Encryption {

        public byte[] EncryptStringToBytes_Aes(string original, byte[] key, byte[] IV) {
            // Check arguments.
            if (original == null || original.Length <= 0) {
                throw new ArgumentNullException("plainText");
            }
            if (key == null || key.Length <= 0) {
                throw new ArgumentNullException("Key");
            }
            if (IV == null || IV.Length <= 0) {
                throw new ArgumentNullException("IV");
            }
            byte[] result;
            // Create an Aes object with the specified key and IV.
            using (Aes aes = Aes.Create()) {
                aes.Key = key;
                aes.IV = IV;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream()) {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
                            //Write all data to the stream.
                            swEncrypt.Write(original);
                        }
                    }
                    result = msEncrypt.ToArray();
                }
            }
            // Return the encrypted bytes from the memory stream.
            return result;
        }

        public string DecryptStringFromBytes_Aes(byte[] original, byte[] key, byte[] IV) {
            // Check arguments.
            if (original == null || original.Length <= 0) {
                throw new ArgumentNullException("Original");
            }
            if (key == null || key.Length <= 0) {
                throw new ArgumentNullException("Key");
            }
            if (IV == null || IV.Length <= 0) {
                throw new ArgumentNullException("IV");
            }
            // Declare the string used to hold the decrypted text.
            string result = null;
            // Create an Aes object with the specified key and IV.
            using (Aes aes = Aes.Create()) {
                aes.Key = key;
                aes.IV = IV;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(original)) {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt)) {
                            try {
                                // Read the decrypted bytes from the decrypting stream and place them in a string.
                                result = srDecrypt.ReadToEnd();
                            }
                            catch (Exception ex) {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
