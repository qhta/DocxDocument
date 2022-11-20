namespace DocumentModel.Vml.Office;

/// <summary>
/// Embedded Object Cannot Be Refreshed.
/// </summary>
public interface ILockedField // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
