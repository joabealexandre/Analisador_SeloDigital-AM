using System;
using System.Collections.Generic;
using System.Text;

namespace SeloEletronicoAM.Classes
{
    public interface ILeitorArquivo<T>
    {
        IList<T> LerSelos(string path);
    }
}
