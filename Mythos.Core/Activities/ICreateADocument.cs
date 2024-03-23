namespace Mythos.Core.Activities
{
	public interface ICreateADocument<T>
	{
		/// <summary>
		/// Creates a document of <typeparamref name="T"/> in a database.
		/// </summary>
		/// <param name="entity">Reference to the <typeparamref name="T"/> to store.</param>
		/// <returns>The entity that was stored.</returns>
		T CreateDocument(T entity);
	}
}
