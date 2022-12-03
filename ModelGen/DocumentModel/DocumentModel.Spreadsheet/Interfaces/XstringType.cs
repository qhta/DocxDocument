namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the XstringType Class.
/// </summary>
public interface XstringType // : System.String
{
  /// <summary>
  /// Content Contains Significant Whitespace
  /// </summary>
  public DocumentModel.SpaceProcessingMode? Space { get ; set; }
  
}
