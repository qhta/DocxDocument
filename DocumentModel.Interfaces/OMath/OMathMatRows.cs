namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the collection of matrix rows.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathmatrows?view=word-pia"/>
public partial interface OMathMatRows : IModelObject, IModelCollection<OMathMatRow>
{
}
