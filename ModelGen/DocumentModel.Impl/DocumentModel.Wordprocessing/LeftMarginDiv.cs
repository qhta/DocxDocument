namespace DocumentModel.Wordprocessing;

/// <summary>
/// Left Margin for HTML div.
/// </summary>
public class LeftMarginDiv: ILeftMarginDiv
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
