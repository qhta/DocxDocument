namespace DocumentModel.Interop;

/// <summary>
/// A collection of Paragraph objects that represents the paragraphs of the specified document, list, or range that have list formatting applied.
/// </summary>
public interface ListParagraphs : InteropObject, InteropCollection<Paragraph>
{
}
