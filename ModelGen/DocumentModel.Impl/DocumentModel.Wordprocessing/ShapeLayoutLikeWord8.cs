namespace DocumentModel.Wordprocessing;

/// <summary>
/// Emulate Word 97 Text Wrapping Around Floating Objects.
/// </summary>
public class ShapeLayoutLikeWord8: IShapeLayoutLikeWord8
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val
  {
    get;
    set;
  }
  
}
