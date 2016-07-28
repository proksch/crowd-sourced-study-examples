namespace task1
{
    /// <summary>
    ///     Interface for the Serializer component.
    ///     !!! Do not chagne this interface, as the automated tests rely on this !!!
    /// </summary>
    public interface ISerializer
    {
        string Serialize(object o);
    }
}