namespace DocumentModel.Interop;

/// <summary>
/// A collection of ListLevel objects that represents all the list levels of a list template, either the only level for a bulleted or numbered list or one of the nine levels of an outline numbered list.
/// </summary>
public interface ListLevels : InteropObject, InteropCollection<ListLevel>
{
}
