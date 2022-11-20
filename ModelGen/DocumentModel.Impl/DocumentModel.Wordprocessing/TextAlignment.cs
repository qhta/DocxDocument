namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextAlignment Class.
/// </summary>
public class TextAlignment: ITextAlignment
{
  /// <summary>
  /// Vertical Character Alignment Position
  /// </summary>
  public VerticalTextAlignmentValues? Val
  {
    get;
    set;
  }
  
}
