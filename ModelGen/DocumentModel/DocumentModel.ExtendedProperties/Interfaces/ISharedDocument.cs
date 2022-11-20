namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Shared Document.
/// </summary>
public interface ISharedDocument // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
