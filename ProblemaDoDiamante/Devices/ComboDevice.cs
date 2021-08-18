using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemaDoDiamante.Devices
{
    /* Veja que neste caso não posso fazer a classe ComboDevice herdar das
     * classes Printer e Scanner, justamente pelo problema do diamente.
     */
    class ComboDevice : Printer, Scanner
    {
    }
}
