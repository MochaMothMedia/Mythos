using System.Reflection;

namespace Mythos.Utilities
{
	public static class DataConverter
	{
		public static T1? ConvertByPropertyNames<T1, T2>(T2? source)
			where T1 : class
			where T2 : class
		{
            if (source == null)
            {
				return null;
            }

            T1? instance = (T1?)Activator.CreateInstance(typeof(T1));

			if (instance == null)
			{
				return null;
			}

			List<PropertyInfo> targetFields = typeof(T1).GetProperties().ToList();
			List<PropertyInfo> sourceFields = typeof(T2).GetProperties().ToList();
			List<string> targetFieldNames = targetFields.Select(field => field.Name).ToList();
			List<string> sourceFieldNames = sourceFields.Select(field => field.Name).ToList();
			for (int i = 0; i < targetFieldNames.Count(); i++)
			{
				int matchingSourceFieldIndex = sourceFieldNames.IndexOf(targetFieldNames[i]);

				if (matchingSourceFieldIndex == -1)
				{
					continue;
				}

				bool bothFieldsAreSameType = sourceFields.ElementAt(matchingSourceFieldIndex).PropertyType == targetFields.ElementAt(i).PropertyType;
				bool typeIsPrimitive = targetFields.ElementAt(i).GetType().IsPrimitive || targetFields.ElementAt(i).PropertyType == typeof(string);

				if (bothFieldsAreSameType)
				{
					if (typeIsPrimitive)
					{
						targetFields.ElementAt(i).SetValue(instance, sourceFields.ElementAt(i).GetValue(source));
					} else
					{
						targetFields.ElementAt(i).SetValue(instance, sourceFields.ElementAt(i).GetValue(source));
					}
				}
			}

			return instance;
		}
	}
}
