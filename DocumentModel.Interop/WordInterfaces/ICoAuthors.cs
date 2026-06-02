namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of all the CoAuthor objects in the document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.coauthors?view=word-pia"/>
public interface ICoAuthors : IInteropObject, IInteropCollection<CoAuthor>
{
}
