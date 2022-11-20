namespace DocumentModel.Bibliography;

/// <summary>
/// Person's First, or Given, Name.
/// </summary>
public interface IFirst // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
