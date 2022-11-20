namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalTextAlignment Class.
/// </summary>
public class VerticalTextAlignment: IVerticalTextAlignment
{
  /// <summary>
  /// Subscript/Superscript Value
  /// </summary>
  public VerticalPositionValues? Val
  {
    get;
    set;
  }
  
}
