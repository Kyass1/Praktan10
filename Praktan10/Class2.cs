using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktan10
{
    internal interface CRUD
    {
        void Create();
        void Read();
        void Update();
        void Delete(int Massiv);
    }
}