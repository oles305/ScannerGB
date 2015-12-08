using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerGB.Buisness.Models
{
    class DocType : IDocType
    {
        #region Fields
        private readonly string docType;
        #endregion

        
        public DocType(string documentType)
        {
            if (String.IsNullOrEmpty(documentType))
            {
                throw new ArgumentNullException();
            }

            this.docType = documentType;
        }

        string IDocType.DocType
        {
            get { return this.docType; }
        }
    }
}
