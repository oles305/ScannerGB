using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerGB.Buisness.Models
{
    public interface IDocument
    {
        string Name { get; }

        DateTime CreateDateTime { get; }

        string DocAddress { get; }
    }
}
