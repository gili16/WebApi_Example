namespace BL
{
    public interface IBL<T>
    {
        List<T> getAll();
        T getById(int id);
        void update(int id, T item);
        void deleteById(int id);
        void AddItem(T item);
        //int getAge(int id);
    }
}