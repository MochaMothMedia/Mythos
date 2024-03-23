namespace Mythos.Core.Database
{
	public interface ISaveADocument<T>
	{
		/// <summary>
		/// Saves an entity to a database.
		/// </summary>
		/// <param name="entity">Entity reference to store.</param>
		/// <returns>True if the operation was successful, otherwise False.</returns>
		bool SaveToDatabase(T entity);
	}
}
