namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Formula1 Class.
/// </summary>
public class Formula1: IFormula1
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
