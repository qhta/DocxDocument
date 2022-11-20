namespace DocumentModel.Spreadsheet;

/// <summary>
/// Even Page Footer.
/// </summary>
public class EvenFooter: IEvenFooter
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
