namespace Mythos.Core.Database
{
	public interface IGetAllDocuments<T>
	{
		/// <summary>
		/// Retrieves all available instances of <typeparamref name="T"/>.
		/// </summary>
		/// <returns>Enumerable of <typeparamref name="T"/>.</returns>
		IEnumerable<T> GetAll();
	}
}
