namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Selection Type.
/// </summary>
public interface ISelectionType // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
