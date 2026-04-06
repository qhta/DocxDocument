namespace DocumentModel.Wordprocessing;

/// <summary>
/// A collection of Conflict objects that represents the conflicts in a document. The type of a Conflict object is specified by the RevisionType enumeration.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts?view=word-pia"/>
public partial interface IConflicts : IModelCollection<IConflict>
{
}
