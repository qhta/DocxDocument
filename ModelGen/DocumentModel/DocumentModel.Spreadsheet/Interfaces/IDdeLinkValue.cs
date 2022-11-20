namespace DocumentModel.Spreadsheet;

/// <summary>
/// DDE Link Value.
/// </summary>
public interface IDdeLinkValue // : DocumentFormat.OpenXml.Spreadsheet.XstringType
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
