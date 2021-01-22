using System;
using System.Collections.Generic;
using System.Text;

namespace Command_Pattern
{
    interface ICommand
    {
        abstract void Execute();
    }

    class JumpCommand : ICommand
    {
        public virtual void Execute()
        {
            Jump
        }
    }

}
