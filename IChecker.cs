namespace Juggler
{
    public interface IChecker<T>
    {
        bool Check(T value);
    }
}
