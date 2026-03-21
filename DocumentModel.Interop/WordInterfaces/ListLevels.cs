namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ListLevel objects that represents all the list levels of a list template, either the only level for a bulleted or numbered list or one of the nine levels of an outline numbered list.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listlevels?view=word-pia"/>
public interface ListLevels : InteropObject, InteropCollection<ListLevel>
{
}
