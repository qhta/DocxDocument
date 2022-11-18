namespace DocumentModel.Office.CustomXsn;

/// <summary>
/// Defines the CachedView Class.
/// </summary>
public interface ICachedView // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
