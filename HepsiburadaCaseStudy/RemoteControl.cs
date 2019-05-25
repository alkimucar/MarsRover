using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HepsiburadaCaseStudy
{

    /// <summary>
    /// This class an invoker, asks the command to accomplish the task
    /// </summary>
    class RemoteControl
    {
        private List<ICommand> _commands = new List<ICommand>();

        public void SendRequest(ICommand command)
        {
            _commands.Add(command);
            command.Execute();
        }
    }
}
