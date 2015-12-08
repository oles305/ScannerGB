using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerGB.Buisness.Models
{
    class Document : IDocument
    {
        #region Fields
        private readonly DateTime createDateTime;
        private readonly string docAddress;
        private readonly string name;
        private readonly bool isShared = false;
        private readonly string defaultValue = "Not set";
        #endregion

        public Document(string name, DateTime createDateTime, bool isShared = false, string docAddress = null)
        {
            if (string.IsNullOrEmpty(name)|| createDateTime == null)
            { 
                throw new ArgumentNullException();
            }
            
            this.createDateTime = createDateTime;
            this.docAddress = docAddress ?? DefaultValue;
            this.isShared = isShared;
            this.name = name;
        }

        public DateTime CreateDateTime
        {
            get { return createDateTime; }
        }

        public string DocAddress
        {
            get { return docAddress; }
        }

        public string Name
        {
            get { return name; }
        }

        public string DefaultValue
        {
            get
            {
                return defaultValue;
            }
        }

        public bool IsShared
        {
            get
            {
                return isShared;
            }
        }

        public override string ToString()
        {
            return $"Name = {Name}\nCreateDateTime = {CreateDateTime}";
        }


    }
}
