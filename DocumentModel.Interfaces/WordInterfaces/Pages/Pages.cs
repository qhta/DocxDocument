namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of pages in a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.pages?view=word-pia"/>
public interface Pages : InteropObject, InteropCollection<Page>
{
}
