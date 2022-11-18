namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Intended Format of Presentation.
/// </summary>
public interface IPresentationFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
