namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a markup element in a WordprocessingML document.
/// This class extends <see cref="ICommonContent"/> and serves as a base for elements that provide additional structure, annotation, or metadata within the document content.
/// </summary>
public interface IMarkupElement : ICommonContent
{
  
}