namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of matrix rows.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows?view=word-pia"/>
public partial interface IOMathMatRows : IInteropObject, IInteropCollection<OMathMatRow>
{
}
