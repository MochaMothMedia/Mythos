namespace Mythos.Core.Activities
{
	public interface ICRUDActivity<T>
	{
		IEnumerable<T> GetAll();
		T? Get(string id);
		T Add(T item);
		T Update(T item);
		T? Remove(string id);
	}
}
