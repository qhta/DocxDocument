namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the CoAuthor objects in the document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthors?view=word-pia"/>
public interface CoAuthors : InteropObject, InteropCollection<CoAuthor>
{
}
