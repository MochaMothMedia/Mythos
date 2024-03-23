namespace Mythos.Core.Database
{
	public interface IGetADocument<T>
	{
		/// <summary>
		/// Retrieves the <typeparamref name="T"/> from a given ID.
		/// </summary>
		/// <returns>The <typeparamref name="T"/>.</returns>
		T? Get(string ID);
	}
}
