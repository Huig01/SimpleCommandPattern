using SimpleCommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCommandPattern.Classes
{
    internal class SimpleRemoteControl
    {
        Command slot;
        public SimpleRemoteControl()
        {

        }

        public void SetCommand(Command command) 
        { 
            slot = command;
        }

        public void ButtonWasPressed()
        {
            slot.Execute();
        }
    }
}
