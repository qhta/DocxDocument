namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the collection of Hyperlink objects in a document, range, or selection.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.hyperlinks?view=word-pia"/>
public partial interface Hyperlinks : InteropObject, InteropCollection<Hyperlink>
{
}
