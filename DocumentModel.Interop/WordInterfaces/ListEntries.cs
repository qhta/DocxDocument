namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of ListEntry objects that represent all the items in a drop-down form field.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries?view=word-pia"/>
public partial interface ListEntries : InteropObject, InteropCollection<ListEntry>
{
}
