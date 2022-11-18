namespace DocumentModel.Spreadsheet;

/// <summary>
/// This provides additional constructors than in the generated files.
/// </summary>
public interface ICellValue // : DocumentFormat.OpenXml.Spreadsheet.XstringType
{
  /// <summary>
  /// Content Contains Significant Whitespace
  /// </summary>
  public SpaceProcessingMode? Space { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
