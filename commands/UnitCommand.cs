using SimpleDispatch.SharedModels.Commands;
using SimpleDispatch.SharedModels.CommandTypes;
using SimpleDispatch.SharedModels.Dtos;

namespace SimpleDispatch.SharedModels.Commands
{
    // Unit-specific commands that can also handle common commands
    public class UnitCommand : FlexibleCommandBase<Unit>
    {
        // Helper methods for type-safe command setting
        public void SetCommand(UnitCommandType command)
        {
            Command = command;
        }

        public void SetCommand(CommonCommandType command)
        {
            Command = command;
        }

        // Helper methods for type-safe command checking
        public bool IsUnitCommand(out UnitCommandType unitCommand)
        {
            if (Command is UnitCommandType unit)
            {
                unitCommand = unit;
                return true;
            }
            unitCommand = default;
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
        public bool IsUnitCommandType => Command is UnitCommandType;
        public bool IsCommonCommandType => Command is CommonCommandType;
    }
}