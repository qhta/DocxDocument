namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents all paragraph objects with list formatting in a document, list, or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listparagraphs?view=word-pia"/>
public interface ListParagraphs : InteropObject, InteropCollection<Paragraph>
{
}
