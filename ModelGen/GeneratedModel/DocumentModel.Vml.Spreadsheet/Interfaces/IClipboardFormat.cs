namespace DocumentModel.Vml.Spreadsheet;

/// <summary>
/// Clipboard Format.
/// </summary>
public interface IClipboardFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
