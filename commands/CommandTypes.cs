namespace SimpleDispatch.SharedModels.CommandTypes
{
    public enum CommonCommandType
    {
        Ping,
        Health,
        Status,
        Heartbeat
    }

    public enum EventCommandType
    {
        CreateEvent,
        UpdateEvent,
        DeleteEvent,
        CloseEvent,
    }

    public enum UnitCommandType
    {
        CreateUnit,
        UpdateUnit,
        LogonUnit,
        LogoffUnit,
        UpdateUnitStatus
    }
}