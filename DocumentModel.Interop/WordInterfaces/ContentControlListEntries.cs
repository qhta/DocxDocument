namespace DocumentModel.Interop.Word;

/// <summary>
/// The ContentControlListEntries collection contains ContentControlListEntry objects that represent the items in a drop-down list or combo box content control.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.contentcontrollistentries?view=word-pia"/>
public partial interface ContentControlListEntries : InteropObject, InteropCollection<ContentControlListEntry>
{
}
