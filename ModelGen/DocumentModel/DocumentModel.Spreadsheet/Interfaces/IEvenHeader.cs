namespace DocumentModel.Spreadsheet;

/// <summary>
/// Even Page Header.
/// </summary>
public interface IEvenHeader // : DocumentFormat.OpenXml.Spreadsheet.XstringType
{
  /// <summary>
  /// Content Contains Significant Whitespace
  /// </summary>
  public SpaceProcessingModeValues? Space { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
