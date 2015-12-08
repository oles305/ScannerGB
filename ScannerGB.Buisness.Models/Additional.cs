using System;

namespace ScannerGB.Buisness.Models
{
    class Additional : IAdditional
    {
        #region
        private readonly string salt;
        #endregion

        public Additional(string salt)
        {
            if (String.IsNullOrEmpty(salt))
            {
                throw new ArgumentNullException();
            }

            this.salt = salt;
        }

        public string Salt
        {
            get { return this.salt; }
        }

    }
}