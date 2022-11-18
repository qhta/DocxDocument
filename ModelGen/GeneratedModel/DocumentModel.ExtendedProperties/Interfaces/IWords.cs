namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Word Count.
/// </summary>
public interface IWords // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
