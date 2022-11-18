namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Selected Entry.
/// </summary>
public interface ISelectionEntry // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
