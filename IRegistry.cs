namespace Juggler
{
    public interface IRegistry<T>
    {
        void Change(T newValue);
    }
}
