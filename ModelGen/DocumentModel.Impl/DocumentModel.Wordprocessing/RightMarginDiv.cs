namespace DocumentModel.Wordprocessing;

/// <summary>
/// Right Margin for HTML div.
/// </summary>
public class RightMarginDiv: IRightMarginDiv
{
  /// <summary>
  /// Positive or Negative Value in Twentieths of a Point
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
