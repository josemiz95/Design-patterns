using System.Collections.Generic;
using System.Linq;

namespace Command
{
    public class CompositeCommands : List<ICommand>, ICommand
    {
        public bool Success { 
            get => this.All(cmd => cmd.Success); 
            set => this.ForEach(cmd => cmd.Success = value);
        }

        public void Execute()
        {
            ForEach(cmd => cmd.Execute());
        }

        public void Undo()
        {
            var reversed = ((IEnumerable<ICommand>)this).Reverse();
            foreach(var cmd in reversed)
            {
                if (cmd.Success) cmd.Undo();
            }
        }
    }
}
