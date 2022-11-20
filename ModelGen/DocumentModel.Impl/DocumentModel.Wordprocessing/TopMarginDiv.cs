namespace DocumentModel.Wordprocessing;

/// <summary>
/// Top Margin for HTML div.
/// </summary>
public class TopMarginDiv: ITopMarginDiv
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
