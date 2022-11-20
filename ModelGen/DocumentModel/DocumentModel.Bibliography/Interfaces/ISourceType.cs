namespace DocumentModel.Bibliography;

/// <summary>
/// Source Type.
/// </summary>
public interface ISourceType // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
