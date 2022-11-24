namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextType Class.
/// </summary>
public interface ITextType // : DocumentModel.ITypedOpenXmlLeafTextElement
{
  /// <summary>
  /// space
  /// </summary>
  public SpaceProcessingMode? Space { get ; set; }
  
}
