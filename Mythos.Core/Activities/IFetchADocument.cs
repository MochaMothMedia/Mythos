namespace Mythos.Core.Activities
{
	public interface IFetchADocument<T>
	{
		/// <summary>
		/// Retrieves a <typeparamref name="T"/> with the given <paramref name="ID"/>.
		/// </summary>
		/// <returns>A <typeparamref name="T"/>.</returns>
		T? GetDocument(string ID);
	}
}
