namespace Mythos.Core.Database
{
	public interface IDeleteADocument<T>
	{
		/// <summary>
		/// Deletes a <typeparamref name="T"/> from a database.
		/// </summary>
		/// <param name="ID"></param>
		/// <returns>The <typeparamref name="T"/> that was deleted.</returns>
		T? Delete(string ID);
	}
}
