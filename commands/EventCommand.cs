using SimpleDispatch.SharedModels.Commands;
using SimpleDispatch.SharedModels.CommandTypes;
using SimpleDispatch.SharedModels.Dtos;

namespace SimpleDispatch.SharedModels.Commands
{
    // Event-specific commands that can also handle common commands
    public class EventCommand : FlexibleCommandBase<Event>
    {
        // Helper methods for type-safe command setting
        public void SetCommand(EventCommandType command)
        {
            Command = command;
        }

        public void SetCommand(CommonCommandType command)
        {
            Command = command;
        }

        // Helper methods for type-safe command checking
        public bool IsEventCommand(out EventCommandType eventCommand)
        {
            if (Command is EventCommandType evt)
            {
                eventCommand = evt;
                return true;
            }
            eventCommand = default;
            return false;
        }

        public bool IsCommonCommand(out CommonCommandType commonCommand)
        {
            if (Command is CommonCommandType common)
            {
                commonCommand = common;
                return true;
            }
            commonCommand = default;
            return false;
        }

        // Property to check what type of command this is
        public bool IsEventCommandType => Command is EventCommandType;
        public bool IsCommonCommandType => Command is CommonCommandType;
    }
}