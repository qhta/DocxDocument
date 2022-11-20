namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Dynamic Data Exchange.
/// </summary>
public interface IDdeObject // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
