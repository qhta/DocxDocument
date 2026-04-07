namespace DocumentModel;

/// <summary>
/// Implementations of this interface represent elements that are part of a document, such as paragraphs, tables, images, etc.
/// </summary>
public interface IDocumentElement
{
  /// <summary>
  /// Gets the parent document that contains this element. This property allows access to the overall document context, enabling elements to interact with other parts of the document, access shared resources, and maintain a reference to the document they belong to.
  /// </summary>
  public Wordprocessing.Document? ParentDocument { get; }
}