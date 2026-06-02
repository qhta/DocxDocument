namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of equations. Use the OMaths object to access individual members of the collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omaths?view=word-pia"/>
public partial interface IOMaths : IInteropObject, IInteropCollection<OMath>
{
}
