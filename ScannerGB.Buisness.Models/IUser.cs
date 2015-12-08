using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScannerGB.Buisness.Models
{
    public interface IUser
    {
        string Name { get; }

        string Surname { get; }

        string UserLogin { get; }

        string UserPassword { get; }

        string Mail { get; }

    }
}
