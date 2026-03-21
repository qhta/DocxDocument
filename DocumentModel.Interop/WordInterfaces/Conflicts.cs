namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Conflict objects that represents the conflicts in a document. The type of a Conflict object is specified by the WdRevisionType enumeration.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.conflicts?view=word-pia"/>
public partial interface Conflicts : InteropObject, InteropCollection<Conflict>
{
}
