using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;
namespace BE
{
    public class PBKDF
    {
        private string hash;
        private byte[] salt;
        public string Hash
        {
            get { return hash; }
            private set { hash = value; }
        }
        public byte[] Salt
        {
            get { return salt; }
            private set { salt = value; }
        }

        private static readonly int saltLength = 16;
        private static readonly int iterationCount = 100000;
        private static readonly int targetSize = 32;

        public PBKDF(string password)
        {

            Salt = GenerateSalt(saltLength);

            Hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: Salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: iterationCount,
                numBytesRequested: targetSize)
            );
        }

        public static bool ValidatePassword(string password, string storedHash, string storedSaltBase64)
        {
            byte[] storedSalt = Convert.FromBase64String(storedSaltBase64);

            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: storedSalt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: iterationCount,
                numBytesRequested: targetSize));

            return hash == storedHash;
        }
        private byte[] GenerateSalt(int length)
        {
            byte[] salt = new byte[length];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }
    }
}
