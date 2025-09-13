using SimpleDispatch.SharedModels.CommandTypes;

namespace SimpleDispatch.SharedModels.Commands
{
    // Common commands that apply to any domain
    public class CommonCommand : CommandBase<CommonCommandType>
    {
        // Additional properties specific to common commands can go here
    }
}