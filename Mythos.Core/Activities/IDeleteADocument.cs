namespace Mythos.Core.Activities
{
	public interface IDeleteADocument<T>
	{
		/// <summary>
		/// Deletes a <typeparamref name="T"/> from the system.
		/// </summary>
		/// <param name="ID">Identifier for the <typeparamref name="T"/>.</param>
		/// <returns>The deleted <typeparamref name="T"/>.</returns>
		T? Delete(string ID);
	}
}
