namespace DocumentModel.Wordprocessing;

/// <summary>
/// Bottom Margin for HTML div.
/// </summary>
public class BottomMarginDiv: IBottomMarginDiv
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
