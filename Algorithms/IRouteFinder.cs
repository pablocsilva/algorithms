namespace Algorithms
{
    public interface IRouteFinder<T, TCost>
    {
        bool TryFindRoute(T from, T to, out Route<T, TCost> route);
    }
}
