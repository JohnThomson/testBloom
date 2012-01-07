using System.Collections.Generic;
using Palaso.Text;

namespace Bloom.Book
{
	/// <summary>
	/// Holds the values we inject and gather from the document.
	/// </summary>
	public class DataSet
	{
		public DataSet()
		{
			WritingSystemCodes = new Dictionary<string, string>();
			TextVariables = new Dictionary<string, DataItem>();
		}
		/// <summary>
		/// Depending on the context, the correct values for these change. E.g., "V" is the *actual* vernacular when looking at a book in the Vernacular library,
		/// but it should be the national language or UI language when looking a shell in a collection (where we'd want to see, for example, the French title)
		///
		/// Values in use currently are: "V", "N1", "N2"
		/// </summary>
		public Dictionary<string, string> WritingSystemCodes { get; private set; }

		public Dictionary<string, DataItem> TextVariables { get; private set; }

		public void AddGenericLanguageString(string key, string value)
		{
			var code = new MultiTextBase();
			code.SetAlternative("*", value);
			TextVariables.Add(key, new DataItem(code, true));
		}
		public void AddLanguageString(string writingSystemId, string key, string value, bool isLibraryValue)
		{
			if(!TextVariables.ContainsKey(key))
			{
				var text = new MultiTextBase();
				TextVariables.Add(key, new DataItem(text, isLibraryValue));
			}
			TextVariables[key].TextAlternatives.SetAlternative(writingSystemId,value);
		}
	}

	public class DataItem
	{
		public DataItem(MultiTextBase text, bool isLibraryValue)
		{
			TextAlternatives = text;
			IsLibraryValue = isLibraryValue;
		}
		public MultiTextBase TextAlternatives;
		public bool IsLibraryValue;
	}
}