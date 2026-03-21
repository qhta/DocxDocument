namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of matrix rows. Use the OMathMatRow object to access individual membes of the collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows?view=word-pia"/>
public partial interface OMathMatRows : InteropObject, InteropCollection<OMathMatRow>
{
}
