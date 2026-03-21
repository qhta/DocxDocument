namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of Paragraph objects that represents the paragraphs of the specified document, list, or range that have list formatting applied.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.listparagraphs?view=word-pia"/>
public interface ListParagraphs : InteropObject, InteropCollection<Paragraph>
{
}
