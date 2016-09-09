using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    interface IMotor
    {

        int cilindrada { get; set; }

        bool iniciar();

        bool frenar();
    }
}
