namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public interface ITextType // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// space
  /// </summary>
  public DocumentModel.SpaceProcessingMode? Space { get ; set; }
  
}
