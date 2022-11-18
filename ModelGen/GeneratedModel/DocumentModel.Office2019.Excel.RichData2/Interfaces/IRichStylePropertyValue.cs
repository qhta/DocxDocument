namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichStylePropertyValue Class.
/// </summary>
public interface IRichStylePropertyValue // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// i, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? I { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
