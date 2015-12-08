using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScannerGB.Buisness.Models;

namespace ScannerGB.Buisness
{
    public interface IDocumentFeeder
    {
        IDocument[] GetDocuments();

    }
}
