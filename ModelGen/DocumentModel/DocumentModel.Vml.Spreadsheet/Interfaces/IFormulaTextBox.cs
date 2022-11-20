namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Text Formula.
/// </summary>
public interface IFormulaTextBox // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
