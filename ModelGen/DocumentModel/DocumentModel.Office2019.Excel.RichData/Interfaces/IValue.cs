namespace DocumentModel.Office2019.Excel.RichData;

/// <summary>
/// Defines the Value Class.
/// </summary>
public interface IValue // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
