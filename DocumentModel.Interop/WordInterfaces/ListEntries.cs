namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all list entry objects in a drop-down form field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listentries?view=word-pia"/>
public partial interface IListEntries : IInteropObject, IInteropCollection<ListEntry>
{
}
