namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Linked Formula.
/// </summary>
public interface IFormulaLink // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
