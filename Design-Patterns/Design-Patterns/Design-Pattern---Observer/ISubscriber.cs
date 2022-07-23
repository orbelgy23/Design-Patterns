namespace Design_Pattern___Observer
{

    public interface ISubscriber
    {
        int Id { get; }
        void Update(int newItem);
    }
}
