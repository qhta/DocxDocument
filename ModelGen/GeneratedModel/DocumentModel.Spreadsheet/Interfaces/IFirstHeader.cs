namespace DocumentModel.Spreadsheet;

/// <summary>
/// First Page Header.
/// </summary>
public interface IFirstHeader // : DocumentFormat.OpenXml.Spreadsheet.XstringType
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
