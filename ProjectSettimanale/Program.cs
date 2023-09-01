using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSettimanale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contribuente.Start();
            Contribuente.CompilazioneDati();
            Contribuente.Stampa();
        }
    }
}
