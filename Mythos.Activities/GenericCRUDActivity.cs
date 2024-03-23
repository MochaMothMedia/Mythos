using Mythos.Core.Activities;

namespace Mythos.Activities
{
	internal class GenericCRUDActivity<T> : ICRUDActivity<T>
	{
		private readonly IFetchAllDocuments<T> _documentAllGetter;
		private readonly IFetchADocument<T> _documentSingleGetter;
		private readonly ICreateADocument<T> _documentCreator;
		private readonly IUpdateADocument<T> _documentUpdater;
		private readonly IDeleteADocument<T> _documentDeleter;

		public GenericCRUDActivity(
			IFetchAllDocuments<T> documentAllGetter,
			IFetchADocument<T> documentSingleGetter,
			ICreateADocument<T> documentCreator,
			IUpdateADocument<T> documentUpdater,
			IDeleteADocument<T> documentDeleter)
		{
			_documentAllGetter = documentAllGetter;
			_documentSingleGetter = documentSingleGetter;
			_documentCreator = documentCreator;
			_documentUpdater = documentUpdater;
			_documentDeleter = documentDeleter;
		}

		public IEnumerable<T> GetAll() => _documentAllGetter.GetDocuments();
		public T Add(T item) => _documentCreator.CreateDocument(item);
		public T? Get(string ID) => _documentSingleGetter.GetDocument(ID);
		public T Update(T entity) => _documentUpdater.UpdateDocument(entity);
		public T? Remove(string ID) => _documentDeleter.Delete(ID);
	}
}
