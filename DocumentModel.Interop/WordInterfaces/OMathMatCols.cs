namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a collection of matrix columns. Use the OMathMatCol object to access individual members of the collection.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatcols?view=word-pia"/>
public partial interface OMathMatCols : InteropObject, InteropCollection<OMathMatCol>
{
}
