namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Highlight Class.
/// </summary>
public class Highlight: IHighlight
{
  /// <summary>
  /// Highlighting Color
  /// </summary>
  public HighlightColorValues? Val
  {
    get;
    set;
  }
  
}
