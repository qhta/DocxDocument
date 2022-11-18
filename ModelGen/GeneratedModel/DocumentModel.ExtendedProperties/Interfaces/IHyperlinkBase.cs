namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Relative Hyperlink Base.
/// </summary>
public interface IHyperlinkBase // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
