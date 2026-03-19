namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Conflict objects that represents the conflicts in a document. The type of a Conflict object is specified by the WdRevisionType enumeration.
/// </summary>
public partial interface Conflicts : InteropObject, InteropCollection<Conflict>
{
}
