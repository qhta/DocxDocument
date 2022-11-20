namespace DocumentModel.Spreadsheet;

/// <summary>
/// Odd Header.
/// </summary>
public class OddHeader: IOddHeader
{
  /// <summary>
  /// Content Contains Significant Whitespace
  /// </summary>
  public SpaceProcessingModeValues? Space
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
