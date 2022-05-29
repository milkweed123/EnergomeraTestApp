using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnergomeraTestApp.Commands
{
    public abstract class BaseCommand
    {
        public string Name { get; }
        public abstract void Execute();
    }
}
