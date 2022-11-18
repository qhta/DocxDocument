namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Name of Manager.
/// </summary>
public interface IManager // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
