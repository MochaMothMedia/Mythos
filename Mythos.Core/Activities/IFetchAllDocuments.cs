namespace Mythos.Core.Activities
{
	public interface IFetchAllDocuments<T>
	{
		/// <summary>
		/// Retrieves all documents of <typeparamref name="T"/>.
		/// </summary>
		/// <returns>Enumerable of <typeparamref name="T"/>.</returns>
		IEnumerable<T> GetDocuments();
	}
}
