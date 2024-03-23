namespace Mythos.Core.Activities
{
	public interface IUpdateADocument<T>
	{
		/// <summary>
		/// Updates a document of <typeparamref name="T"/> in a database.
		/// </summary>
		/// <param name="entity">Reference to the <typeparamref name="T"/> to update.</param>
		/// <returns>The entity that was updated.</returns>
		T UpdateDocument(T entity);
	}
}
