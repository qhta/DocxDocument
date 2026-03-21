namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Revision objects that represent the changes marked with revision marks in a range or document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.revisions?view=word-pia"/>
public partial interface Revisions : InteropObject, InteropCollection<Revision>
{
}
